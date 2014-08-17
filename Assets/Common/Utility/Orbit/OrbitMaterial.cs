﻿using UnityEngine;
using System.Collections.Generic;
using System.Linq;

[RequireComponent(typeof(MeshFilter)), RequireComponent(typeof(MeshRenderer))]
public class OrbitMaterial : MonoBehaviour {
				public OrbitObject[]	m_OrbitObjects;
				public MeshFilter		m_MeshFilter;
				public Mesh				m_Mesh;
				public MeshRenderer		m_MeshRenderer;
				public Material			m_Material;
	[EnumMask]	public Flag				m_Flag;
	private Stack<int>	m_UnusedOrbitIndices;
	private Vector3[]	m_VerticesCache;
	private Vector4[]	m_TangentsCache;
	private int[]		m_IndicesCache;

	[System.Flags]
	public enum Flag {
		FreezeDraw	= 1 << 0,	//更新無し
		DirtyIndex	= 1 << 1,	//インデックス要更新
		DirtyUv		= 1 << 2,	//UV要更新
		DirtyColor	= 1 << 3,	//カラー要更新
	}

	/// <summary>
	/// 使用していない軌道物体インデックスの取得
	/// </summary>
	/// <returns>使用していない軌道物体インデックス</returns>
	public int AllocOrbitIndices() {
		int result = -1;
		if (0 < m_UnusedOrbitIndices.Count) {
			result = m_UnusedOrbitIndices.Pop();
		}
		return result;
	}

	/// <summary>
	/// 使用している軌道物体インデックスの返却
	/// </summary>
	/// <param name="index">返却する軌道物体インデックス</param>
	public void FreeOrbitIndices(int index) {
		if ((index < m_OrbitObjects.Length) && !m_UnusedOrbitIndices.Contains(index)) {
			m_UnusedOrbitIndices.Push(index);
		}
	}

	/// <summary>
	/// 軌道物体数取得
	/// </summary>
	/// <returns></returns>
	public int GetOrbitCount() {
		int result = m_OrbitObjects.Length - m_UnusedOrbitIndices.Count;
		return result;
	}

	/// <summary>
	/// 廃棄済み物体数取得
	/// </summary>
	/// <returns></returns>
	public int GetTrashCount() {
		int result = m_UnusedOrbitIndices.Count;
		return result;
	}

	/// <summary>
	/// 生成
	/// </summary>
	void Awake() {
		m_MeshFilter = GetComponent<MeshFilter>();
		m_MeshRenderer = GetComponent<MeshRenderer>();
		m_UnusedOrbitIndices = new Stack<int>(m_OrbitObjects.Length);
		for (int i = m_OrbitObjects.Length - 1, i_min = 0; i_min <= i; --i) {
			m_UnusedOrbitIndices.Push(i);
		}
		m_VerticesCache = new Vector3[0];
	}
	
	/// <summary>
	/// 初回更新前
	/// </summary>
	void Start() {
		if (!m_Mesh) {
			m_Mesh = new Mesh();
			m_Mesh.name = "OrbitMesh";
			m_Mesh.MarkDynamic();
			var vertices_length = m_OrbitObjects.Length * 4;
			m_Mesh.vertices = Enumerable.Repeat(Vector3.zero, vertices_length).ToArray();
		}
		m_MeshFilter.sharedMesh = m_Mesh;
		if (!m_Material) {
			enabled = false;
		} else {
			m_MeshRenderer.sharedMaterial = m_Material;
		}
	}
	
	/// <summary>
	/// 更新
	/// </summary>
	void Update() {
	}
	
	/// <summary>
	/// 後更新
	/// </summary>
	void LateUpdate() {
		if (0 == (Flag.FreezeDraw & m_Flag)) {
			CreateMeshCache();
			ApplyMesh();
		}
	}
	
	/// <summary>
	/// メッシュ更新
	/// </summary>
	void CreateMeshCache() {
		//頂点更新
		CreateVerticesCache();
		CreateIndicesCache();
	}
	
	/// <summary>
	/// 頂点更新
	/// </summary>
	void CreateVerticesCache() {
		var vertices_length = m_OrbitObjects.Length * 4;
		m_TangentsCache = new Vector4[vertices_length];
		int k = 0;
		for (int i = 0, i_max = m_OrbitObjects.Length; i < i_max; ++i) {
			//位置・UV・カラー更新
			var colors = m_OrbitObjects[i].colors.GetEnumerator();
			var uvs = m_OrbitObjects[i].uvs.GetEnumerator();
			foreach (var vertex in m_OrbitObjects[i].vertices) {
				colors.MoveNext();
				var color = colors.Current;
				uvs.MoveNext();
				var uv = uvs.Current;

				//符号部をSign、指数部をExponent、仮数部をFfractionとした場合、IEEE754のfloatはS1E8F23の形式を取る
				//S1E8には全く情報を乗せずに、F23だけを使い複数の情報をパックする
				//頂点・UVパック: 頂点座標11bit(-1024～1023の領域を0～2047として扱う)、UV11bit(0.0～1.0の領域を0.0～0.5として扱う)、空き1bit
				//カラー2ch: カラー(1ch)11bit(0.0～1.0の領域を0.0～0.5として扱う)、カラー(1ch)11bit(0.0～1.0の領域を0.0～0.5として扱う)、空き1bit
				m_TangentsCache[k++] = new Vector4(((int)(vertex.x + 1024.0f) / 2048.0f) + (int)(uv.x / 2.0f * 2048.0f) / 2048.0f / 2048.0f
													, ((int)(vertex.y + 1024.0f) / 2048.0f) + (int)(uv.y / 2.0f * 2048.0f) / 2048.0f / 2048.0f
													, (int)(color.r / 2.0f * 2048.0f) / 2048.0f + (int)(color.b / 2.0f * 2048.0f) / 2048.0f / 2048.0f
													, (int)(color.g / 2.0f * 2048.0f) / 2048.0f + (int)(color.a / 2.0f * 2048.0f) / 2048.0f / 2048.0f
													);
			}
		}
	}
	
	/// <summary>
	/// インデックス更新
	/// </summary>
	void CreateIndicesCache() {
		//インデックス更新
		if (0 != (Flag.DirtyIndex & m_Flag)) {
			var draw_order_index = Enumerable.Range(0, m_OrbitObjects.Length).ToList();
			draw_order_index.Sort((x,y)=>{
				if (m_OrbitObjects[x].order != m_OrbitObjects[y].order) {
					//orderに差が有れば
					//order順
					return m_OrbitObjects[x].order - m_OrbitObjects[y].order;
				} else {
					//initorder順
					return m_OrbitObjects[x].initorder - m_OrbitObjects[y].initorder;
				}
			});
			
			m_IndicesCache = draw_order_index.Select(x=>x * 4)
										.SelectMany(x=>new[]{x + 0, x + 1, x + 2, x + 1, x + 3, x + 2})
										.ToArray();
		}
	}
	
	/// <summary>
	/// メッシュの適応
	/// </summary>
	void ApplyMesh() {
		m_Mesh.tangents = m_TangentsCache;
		if (0 != (Flag.DirtyIndex & m_Flag)) {
			m_Mesh.SetIndices(m_IndicesCache, MeshTopology.Triangles, 0);
		}
		m_Flag &= ~(Flag.DirtyIndex | Flag.DirtyUv | Flag.DirtyColor);
	}

}

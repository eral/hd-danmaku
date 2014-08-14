using UnityEngine;
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
	private Vector2[]	m_UvsCache;
	private Color[]		m_ColorsCache;
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
		var vertices_length = m_OrbitObjects.Length * 4;
		if (m_VerticesCache.Length != vertices_length) {
			m_VerticesCache = new Vector3[vertices_length];
			m_UvsCache = new Vector2[vertices_length];
			m_ColorsCache = new Color[vertices_length];

			m_Flag |= Flag.DirtyIndex | Flag.DirtyUv | Flag.DirtyColor;
		}
		CreateVerticesCache();
		CreateIndicesCache();
	}
	
	/// <summary>
	/// 頂点更新
	/// </summary>
	void CreateVerticesCache() {
		for (int i = 0, i_max = m_OrbitObjects.Length; i < i_max; ++i) {
			//位置更新
			int k = i * 4;
			foreach (var vertex in m_OrbitObjects[i].vertices) {
				m_VerticesCache[k++] = vertex;
			}
			//UV更新
			if (0 != (Flag.DirtyUv & m_Flag)) {
				k = i * 4;
				foreach (var uv in m_OrbitObjects[i].uvs) {
					m_UvsCache[k++] = uv;
				}
			}
			//カラー更新
			if (0 != (Flag.DirtyColor & m_Flag)) {
				k = i * 4;
				foreach (var color in m_OrbitObjects[i].colors) {
					m_ColorsCache[k++] = color;
				}
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
		m_Mesh.vertices = m_VerticesCache;
		if (0 != (Flag.DirtyUv & m_Flag)) {
			m_Mesh.uv = m_UvsCache;
		}
		if (0 != (Flag.DirtyColor & m_Flag)) {
			m_Mesh.colors = m_ColorsCache;
		}
		if (0 != (Flag.DirtyIndex & m_Flag)) {
			m_Mesh.SetIndices(m_IndicesCache, MeshTopology.Triangles, 0);
		}
		m_Flag &= ~(Flag.DirtyIndex | Flag.DirtyUv | Flag.DirtyColor);
	}

}

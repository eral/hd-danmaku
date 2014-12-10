using UnityEngine;
using System.Collections.Generic;
using System.Linq;

[RequireComponent(typeof(MeshFilter)), RequireComponent(typeof(MeshRenderer))]
public class OrbitRenderer : MonoBehaviour {
	public OrbitObject[]	m_OrbitObjects;
	public MeshFilter		m_MeshFilter;
	public Mesh				m_Mesh;
	public MeshRenderer		m_MeshRenderer;
	public Material			m_Material;
	public bool				m_IgnoreOrderSort	= false;
	public System.Action	m_DestoryCb	= null;
	private Stack<int>	m_UnusedOrbitIndices;

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
			if (0 == GetOrbitCount()) {
				Object.Destroy(gameObject);
			}
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
	}

	/// <summary>
	/// 破棄
	/// </summary>
	void OnDestroy() {
		if (null != m_DestoryCb) {
			m_DestoryCb();
		}
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
			var indices = Enumerable.Range(0, m_OrbitObjects.Length).Select(x=>x * 4).SelectMany(x=>new[]{x + 0, x + 1, x + 2, x + 1, x + 3, x + 2}).ToArray();
			m_Mesh.SetIndices(indices, MeshTopology.Triangles, 0);
		}
		m_MeshFilter.sharedMesh = m_Mesh;
		if (!m_Material) {
			enabled = false;
		} else {
			m_MeshRenderer.sharedMaterial = m_Material;
			m_IgnoreOrderSort = 0.0f == m_Material.GetFloat("RequireOrderSort");
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
		UpdateMesh();
	}
	
	/// <summary>
	/// メッシュ更新
	/// </summary>
	void UpdateMesh() {
		int[] draw_order_inverse;
		if (m_IgnoreOrderSort) {
			//オーダーソートしない
			draw_order_inverse = Enumerable.Range(0, m_OrbitObjects.Length).Select(x=>x*4).ToArray();
		} else {
			//オーダーソートする
			var draw_order_array = Enumerable.Range(0, m_OrbitObjects.Length).ToArray();
			System.Array.Sort(draw_order_array, (x,y)=>{
				if (m_OrbitObjects[x].order != m_OrbitObjects[y].order) {
					//orderに差が有れば
					//order順
					return m_OrbitObjects[x].order - m_OrbitObjects[y].order;
				} else {
					//initorder順
					return m_OrbitObjects[x].initorder - m_OrbitObjects[y].initorder;
				}
			});
			draw_order_inverse = new int[draw_order_array.Length];
			for (int i = 0, i_max = draw_order_array.Length; i < i_max; ++i) {
				draw_order_inverse[draw_order_array[i]] = i * 4;
			}
		}

		var vertices_length = m_OrbitObjects.Length * 4;
		var tangents = new Vector4[vertices_length];
		for (int i = 0, i_max = m_OrbitObjects.Length; i < i_max; ++i) {
			//位置・UV・カラー更新
			int dst = draw_order_inverse[i];

			var color = m_OrbitObjects[i].color;
			var tangent = new Vector4(0.0f
									, 0.0f
									, (int)(color.r / 2.0f * 2048.0f) / 2048.0f + (int)(color.b / 2.0f * 2048.0f) / 2048.0f / 2048.0f
									, (int)(color.g / 2.0f * 2048.0f) / 2048.0f + (int)(color.a / 2.0f * 2048.0f) / 2048.0f / 2048.0f
									);

			var uvs = m_OrbitObjects[i].uvs.GetEnumerator();
			foreach (var vertex in m_OrbitObjects[i].vertices) {
				uvs.MoveNext();
				var uv = uvs.Current;

				//符号部をSign、指数部をExponent、仮数部をFfractionとした場合、IEEE754のfloatはS1E8F23の形式を取る
				//S1E8には全く情報を乗せずに、F23だけを使い複数の情報をパックする
				//頂点・UVパック: 頂点座標11bit(-1024～1023の領域を0～2047として扱う)、UV11bit(0.0～1.0の領域を0.0～0.5として扱う)、空き1bit
				//カラー2ch: カラー(1ch)11bit(0.0～1.0の領域を0.0～0.5として扱う)、カラー(1ch)11bit(0.0～1.0の領域を0.0～0.5として扱う)、空き1bit
				tangent.x = ((int)(vertex.x + 1024.0f) / 2048.0f) + (int)(uv.x / 2.0f * 2048.0f) / 2048.0f / 2048.0f;
				tangent.y = ((int)(vertex.y + 1024.0f) / 2048.0f) + (int)(uv.y / 2.0f * 2048.0f) / 2048.0f / 2048.0f;
				tangents[dst++] = tangent;
			}
		}
		m_Mesh.tangents = tangents;
	}

}

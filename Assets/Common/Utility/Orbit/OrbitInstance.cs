using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class OrbitInstance : MonoBehaviour {
	static OrbitInstance s_Instance = null;
	static GameObject s_MaterialPrefab = null;
	Dictionary<int, List<OrbitRenderer>> m_Material;

	/// <summary>
	/// インスタンス作成
	/// </summary>
	public static OrbitInstance Instantiate() {
		if (null == s_Instance) {
			//未生成なら
			//生成(s_Instanceへの設定はAwake()で行う)
			new GameObject("OrbitInstance", typeof(OrbitInstance));
		}
		return s_Instance;
	}

	/// <summary>
	/// 軌道レンダラー取得作成
	/// </summary>
	/// <param name="orbit_material">軌道マテリアル</param>
	/// <returns>軌道レンダラー</returns>
	public OrbitRenderer GetRenderer(OrbitMaterial orbit_material) {
		OrbitRenderer result = null;
		int hash = orbit_material.m_Material.GetHashCode();
		List<OrbitRenderer> renderers = null;
		if (m_Material.ContainsKey(hash)) {
			//既出なら
			renderers = m_Material[hash];
			//それを返す
			result = renderers.FirstOrDefault(x=>0 < x.GetTrashCount());
		}
		if (null == result) {
			//無ければ
			//新規作成
			var game_object = (GameObject)Instantiate(s_MaterialPrefab);
			game_object.transform.parent = this.transform;
			result = game_object.GetComponent<OrbitRenderer>();
			result.m_Material = orbit_material.m_Material;
			if (null != renderers) {
				renderers.Add(result);
			} else {
				renderers = new List<OrbitRenderer>(new[]{result});
				m_Material.Add(hash, renderers);
			}
			result.m_DestoryCb = ()=>{
				//レンダラーが消失した時は管理マテリアルから消去
				renderers.Remove(result);
				if (0 == renderers.Count) {
					m_Material.Remove(hash);
				}
			};
		}
		return result;
	}

	/// <summary>
	/// 軌道レンダラーリスト取得作成
	/// </summary>
	/// <returns>軌道レンダラーリスト</returns>
	public IEnumerable<OrbitRenderer> GetRendererList() {
		IEnumerable<OrbitRenderer> result = m_Material.SelectMany(x=>x.Value);
		return result;
	}

	/// <summary>
	/// 軌道物体数取得
	/// </summary>
	/// <returns></returns>
	public int GetOrbitCount() {
		int result = m_Material.SelectMany(x=>x.Value)
								.Select(x=>x.GetOrbitCount())
								.Sum();
		return result;
	}

	/// <summary>
	/// 廃棄済み物体数取得
	/// </summary>
	/// <returns></returns>
	public int GetTrashCount() {
		int result = m_Material.SelectMany(x=>x.Value)
								.Select(x=>x.GetTrashCount())
								.Sum();
		return result;
	}

	/// <summary>
	/// 生成
	/// </summary>
	void Awake() {
		s_Instance = this;
		s_MaterialPrefab = (GameObject)Resources.Load("OrbitMaterial");
		m_Material = new Dictionary<int, List<OrbitRenderer>>();
	}
}

using UnityEngine;
using System.Collections.Generic;

public class OrbitInstance : MonoBehaviour {
	static OrbitInstance s_Instance = null;
	static GameObject s_MaterialPrefab = null;
	Dictionary<int, OrbitRenderer> m_Material;

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
	/// マテリアル取得作成
	/// </summary>
	public OrbitRenderer GetOrbitMaterial(Material material) {
		OrbitRenderer result = null;
		int hash = material.GetHashCode();
		if (m_Material.ContainsKey(hash)) {
			//既出なら
			//それを返す
			result = m_Material[hash];
		} else {
			//無ければ
			//新規作成
			var game_object = (GameObject)Instantiate(s_MaterialPrefab);
			game_object.transform.parent = this.transform;
			result = game_object.GetComponent<OrbitRenderer>();
			result.m_Material = material;
			m_Material.Add(hash, result);
		}
		return result;
	}
	public OrbitRenderer GetOrbitMaterial(string material_path, Texture texture) {
		Material material = (Material)Resources.Load(material_path);
		material.mainTexture = texture;
		return GetOrbitMaterial(material);
	}

	/// <summary>
	/// 軌道物体数取得
	/// </summary>
	/// <returns></returns>
	public int GetOrbitCount() {
		int result = 0;
		foreach (var material in m_Material) {
			result += material.Value.GetOrbitCount();
		}
		return result;
	}

	/// <summary>
	/// 廃棄済み物体数取得
	/// </summary>
	/// <returns></returns>
	public int GetTrashCount() {
		int result = 0;
		foreach (var material in m_Material) {
			result += material.Value.GetTrashCount();
		}
		return result;
	}

	/// <summary>
	/// 生成
	/// </summary>
	void Awake() {
		s_Instance = this;
		s_MaterialPrefab = (GameObject)Resources.Load("OrbitMaterial");
		m_Material = new Dictionary<int,OrbitRenderer>();
	}
}

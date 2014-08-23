using UnityEngine;
using System.Collections;

[System.Serializable]
public class Orbit : System.IDisposable {
	[SerializeField] private OrbitRenderer	m_Material = null;
	[SerializeField] private int			m_Index = -1;

	/// <summary>
	/// インスタンス作成
	/// </summary>
	/// <param name="sprite">設定するスプライト</param>
	/// <returns>インスタンス</returns>
	public static Orbit Instantiate(Sprite sprite) {
		Orbit result = new Orbit();
		var orbit_instance = OrbitInstance.Instantiate();
		var material = orbit_instance.GetOrbitMaterial("OrbitAlpha", sprite.texture);
		result.m_Index = material.AllocOrbitIndices();
		result.m_Material = material;
		result.m_Material.m_OrbitObjects[result.m_Index].Init(sprite);
		return result;
	}

	/// <summary>
	/// インスタンス作成
	/// </summary>
	/// <param name="sprite">設定するスプライト</param>
	/// <returns>インスタンス</returns>
	public static Orbit Instantiate(OrbitRenderer material, int index) {
		Orbit result = new Orbit();
		result.m_Material = material;
		result.m_Index = index;
		return result;
	}

	/// <summary>
	/// インスタンス破棄
	/// </summary>
	/// <param name="sprite">インスタンス</param>
	public static void Destory(Orbit orbit) {
		orbit.m_Material.m_OrbitObjects[orbit.m_Index].Init(null);
		orbit.m_Material.FreeOrbitIndices(orbit.m_Index);
		orbit.m_Material = null;
		orbit.m_Index = -1;
	}

	/// <summary>
	/// Disposeインターフェース
	/// </summary>
	public void Dispose() {
		if (null != m_Material) {
			m_Material.FreeOrbitIndices(m_Index);

			m_Material = null;
			m_Index = -1;
		}
	}

	public bool valid {
		get{return m_Material.m_OrbitObjects[m_Index].valid;}
	}

	public int user_flag {
		get{return m_Material.m_OrbitObjects[m_Index].user_flag;}
		set{m_Material.m_OrbitObjects[m_Index].user_flag = value;}
	}

	public Vector3 position {
		get{return m_Material.m_OrbitObjects[m_Index].position;}
		set{m_Material.m_OrbitObjects[m_Index].position = value;}
	}

	public Quaternion rotation {
		get{return m_Material.m_OrbitObjects[m_Index].rotation;}
		set{m_Material.m_OrbitObjects[m_Index].rotation = value;}
	}

	public Vector3 scale {
		get{return m_Material.m_OrbitObjects[m_Index].scale;}
		set{m_Material.m_OrbitObjects[m_Index].scale = value;}
	}

	public Vector3 velocity_position {
		get{return m_Material.m_OrbitObjects[m_Index].velocity_position;}
		set{m_Material.m_OrbitObjects[m_Index].velocity_position = value;}
	}

	public Quaternion velocity_rotation {
		get{return m_Material.m_OrbitObjects[m_Index].velocity_rotation;}
		set{m_Material.m_OrbitObjects[m_Index].velocity_rotation = value;}
	}

	public Vector3 velocity_scale {
		get{return m_Material.m_OrbitObjects[m_Index].velocity_scale;}
		set{m_Material.m_OrbitObjects[m_Index].velocity_scale = value;}
	}

	public Bounds collider_bounds {
		get{return m_Material.m_OrbitObjects[m_Index].collider_bounds;}
		set{m_Material.m_OrbitObjects[m_Index].collider_bounds = value;}
	}

	public Color color {
		get{return m_Material.m_OrbitObjects[m_Index].color;}
		set{m_Material.m_OrbitObjects[m_Index].color = value;}
	}

	public int order {
		get{return m_Material.m_OrbitObjects[m_Index].order;}
		set{m_Material.m_OrbitObjects[m_Index].order = value;}
	}
}

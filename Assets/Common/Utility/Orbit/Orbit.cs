using UnityEngine;
using System.Collections;

[System.Serializable]
public class Orbit : System.IDisposable {
	[SerializeField] private OrbitMaterial	m_Material	= null;
	[SerializeField] private OrbitObject	m_Orbit		= null;

	/// <summary>
	/// インスタンス作成
	/// </summary>
	/// <param name="sprite">設定するスプライト</param>
	/// <returns>インスタンス</returns>
	public static Orbit Instantiate(Sprite sprite) {
		Orbit result = new Orbit();
		var orbit_instance = OrbitInstance.Instantiate();
		var material = orbit_instance.GetOrbitMaterial("OrbitAlpha", sprite.texture);
		result.m_Orbit = material.AllocOrbitIndices();
		result.m_Material = material;
		result.m_Orbit.Init(sprite);
		result.m_Material.m_Flag |= OrbitMaterial.Flag.DirtyIndex | OrbitMaterial.Flag.DirtyUv | OrbitMaterial.Flag.DirtyColor;
		return result;
	}

	/// <summary>
	/// インスタンス作成
	/// </summary>
	/// <param name="sprite">設定するスプライト</param>
	/// <returns>インスタンス</returns>
	public static Orbit Instantiate(OrbitMaterial material, OrbitObject orbit) {
		Orbit result = new Orbit();
		result.m_Material = material;
		result.m_Orbit = orbit;
		return result;
	}

	/// <summary>
	/// インスタンス破棄
	/// </summary>
	/// <param name="sprite">インスタンス</param>
	public static void Destory(Orbit orbit) {
		orbit.m_Orbit.Init(null);
		orbit.m_Material.FreeOrbitIndices(orbit.m_Orbit);
		orbit.m_Material = null;
		orbit.m_Orbit = null;
	}

	/// <summary>
	/// Disposeインターフェース
	/// </summary>
	public void Dispose() {
		if (null != m_Material) {
			m_Material.FreeOrbitIndices(m_Orbit);

			m_Material = null;
			m_Orbit = null;
		}
	}

	public bool valid {
		get{return m_Orbit.valid;}
	}

	public int user_flag {
		get{return m_Orbit.user_flag;}
		set{m_Orbit.user_flag = value;}
	}

	public Vector3 position {
		get{return m_Orbit.position;}
		set{m_Orbit.position = value;}
	}

	public Quaternion rotation {
		get{return m_Orbit.rotation;}
		set{m_Orbit.rotation = value;}
	}

	public Vector3 scale {
		get{return m_Orbit.scale;}
		set{m_Orbit.scale = value;}
	}

	public Vector2 velocity_position {
		get{return m_Orbit.velocity_position;}
		set{m_Orbit.velocity_position = value;}
	}

	public float velocity_rotation {
		get{return m_Orbit.velocity_rotation;}
		set{m_Orbit.velocity_rotation = value;}
	}

	public Color color {
		get{return m_Orbit.color;}
		set{
			m_Orbit.color = value;
			m_Material.m_Flag |= OrbitMaterial.Flag.DirtyColor;
		}
	}

	public int order {
		get{return m_Orbit.order;}
		set{
			m_Orbit.order = value;
			m_Material.m_Flag |= OrbitMaterial.Flag.DirtyIndex;
		}
	}
}

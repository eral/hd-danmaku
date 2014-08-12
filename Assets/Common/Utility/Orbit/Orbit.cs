using UnityEngine;
using System.Collections;

[System.Serializable]
public class Orbit : System.IDisposable {
	[SerializeField] private OrbitMaterial	m_Material = null;
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
		result.m_Material.m_Flag |= OrbitMaterial.Flag.DirtyIndex | OrbitMaterial.Flag.DirtyUv | OrbitMaterial.Flag.DirtyColor;
		return result;
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

	public Color color {
		get{return m_Material.m_OrbitObjects[m_Index].color;}
		set{
			m_Material.m_OrbitObjects[m_Index].color = value;
			m_Material.m_Flag |= OrbitMaterial.Flag.DirtyColor;
		}
	}

	public int order {
		get{return m_Material.m_OrbitObjects[m_Index].order;}
		set{
			m_Material.m_OrbitObjects[m_Index].order = value;
			m_Material.m_Flag |= OrbitMaterial.Flag.DirtyIndex;
		}
	}
}

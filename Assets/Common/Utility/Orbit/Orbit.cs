using UnityEngine;
using System.Collections.Generic;
using System.Linq;

[System.Serializable]
public class Orbit : System.IDisposable {
	[SerializeField] private OrbitRenderer	m_Renderer = null;
	[SerializeField] private int			m_Index = -1;

	/// <summary>
	/// インスタンス作成
	/// </summary>
	/// <param name="material">マテリアル</param>
	/// <returns>インスタンス</returns>
	public static Orbit Instantiate(OrbitMaterial orbit_material) {
		var orbit_instance = OrbitInstance.Instantiate();
		var renderer = orbit_instance.GetRenderer(orbit_material);
		var index = renderer.AllocOrbitIndices();
		renderer.m_OrbitObjects[index].Init(orbit_material);
		Orbit result = new Orbit(renderer, index);
		return result;
	}

	/// <summary>
	/// インスタンス破棄
	/// </summary>
	/// <param name="sprite">インスタンス</param>
	public static void Destory(Orbit orbit) {
		orbit.m_Renderer.m_OrbitObjects[orbit.m_Index].Init(null);
		orbit.Dispose();
	}

	/// <summary>
	/// インスタンスリスト取得
	/// </summary>
	/// <returns>インスタンス</returns>
	public static IEnumerable<Orbit> GetInstanceList() {
		var orbit_renderer_list = OrbitInstance.Instantiate().GetRendererList();
		var result = orbit_renderer_list.SelectMany(x=>Enumerable.Range(0, x.m_OrbitObjects.Length).Select(y=>new{renderer=x, index=y}))
										.Where(x=>x.renderer.m_OrbitObjects[x.index].valid)
										.Select(x=>new Orbit(x.renderer, x.index));
		return result;
	}

	/// <summary>
	/// Disposeインターフェース
	/// </summary>
	public void Dispose() {
		Unlink();
	}

	/// <summary>
	/// コンストラクタ
	/// </summary>
	internal Orbit(OrbitRenderer renderer, int index) {
		Link(renderer, index);
	}

	/// <summary>
	/// マテリアル切り替え
	/// </summary>
	/// <param name="material">マテリアル</param>
	public void ChangeMaterial(OrbitMaterial orbit_material) {
		var orbit_instance = OrbitInstance.Instantiate();
		var renderer = orbit_instance.GetRenderer(orbit_material);
		//位置保存
		var prev_position = position;
		var prev_rotation = rotation;
		var prev_scale = scale;
		if (m_Renderer == renderer) {
			//レンダラー使い回し可能
			renderer.m_OrbitObjects[m_Index].Init(orbit_material);
		} else {
			//レンダラー使い回し不可能
			Unlink();
			var index = renderer.AllocOrbitIndices();
			renderer.m_OrbitObjects[index].Init(orbit_material);
			Link(renderer, index);
		}
		//位置復元
		position = prev_position;
		rotation = prev_rotation;
		scale = prev_scale;
	}

	public bool valid {
		get{return m_Renderer.m_OrbitObjects[m_Index].valid;}
	}

	public bool	move_only {
		get{return m_Renderer.m_OrbitObjects[m_Index].move_only;}
		set{m_Renderer.m_OrbitObjects[m_Index].move_only = value;}
	}

	public bool player_homing {
		get{return m_Renderer.m_OrbitObjects[m_Index].player_homing;}
		set{m_Renderer.m_OrbitObjects[m_Index].player_homing = value;}
	}

	public OrbitMaterial.Tag tag {
		get{return m_Renderer.m_OrbitObjects[m_Index].tag;}
		set{m_Renderer.m_OrbitObjects[m_Index].tag = value;}
	}

	public Vector3 position {
		get{return m_Renderer.m_OrbitObjects[m_Index].position;}
		set{m_Renderer.m_OrbitObjects[m_Index].position = value;}
	}

	public Quaternion rotation {
		get{return m_Renderer.m_OrbitObjects[m_Index].rotation;}
		set{m_Renderer.m_OrbitObjects[m_Index].rotation = value;}
	}

	public Vector3 scale {
		get{return m_Renderer.m_OrbitObjects[m_Index].scale;}
		set{m_Renderer.m_OrbitObjects[m_Index].scale = value;}
	}

	public Vector3 velocity_position {
		get{return m_Renderer.m_OrbitObjects[m_Index].velocity_position;}
		set{m_Renderer.m_OrbitObjects[m_Index].velocity_position = value;}
	}

	public Quaternion velocity_rotation {
		get{return m_Renderer.m_OrbitObjects[m_Index].velocity_rotation;}
		set{m_Renderer.m_OrbitObjects[m_Index].velocity_rotation = value;}
	}

	public Vector3 velocity_scale {
		get{return m_Renderer.m_OrbitObjects[m_Index].velocity_scale;}
		set{m_Renderer.m_OrbitObjects[m_Index].velocity_scale = value;}
	}

	public Bounds collider_bounds {
		get{return m_Renderer.m_OrbitObjects[m_Index].collider_bounds;}
		set{m_Renderer.m_OrbitObjects[m_Index].collider_bounds = value;}
	}

	public Color color {
		get{return m_Renderer.m_OrbitObjects[m_Index].color;}
		set{m_Renderer.m_OrbitObjects[m_Index].color = value;}
	}

	public int order {
		get{return m_Renderer.m_OrbitObjects[m_Index].order;}
		set{m_Renderer.m_OrbitObjects[m_Index].order = value;}
	}

	private void Link(OrbitRenderer renderer, int index) {
		m_Renderer = renderer;
		m_Index = index;
	}

	private void Unlink() {
		if (null != m_Renderer) {
			m_Renderer.FreeOrbitIndices(m_Index);
			m_Renderer = null;
			m_Index = -1;
		}
	}
}

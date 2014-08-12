using UnityEngine;
using System.Collections.Generic;
using System.Linq;

[RequireComponent(typeof(OrbitMaterial))]
public class OrbitUpdater : MonoBehaviour {
	public OrbitMaterial	m_OrbitMaterial;

	/// <summary>
	/// 生成
	/// </summary>
	void Awake() {
		m_OrbitMaterial = GetComponent<OrbitMaterial>();
	}
	
	/// <summary>
	/// 更新
	/// </summary>
	void Update() {
		OrbitalCalculation(m_OrbitMaterial.m_OrbitObjects, Time.deltaTime);
	}

	/// <summary>
	/// 軌道計算
	/// </summary>
	/// <param name="srces">軌道物体群</param>
	private static void OrbitalCalculation(OrbitObject[] srces, float delta_time) {
		for (int i = 0, i_max = srces.Length; i < i_max; ++i) {
			OrbitalCalculation(ref srces[i], delta_time);
		}
	}
	
	/// <summary>
	/// 軌道計算
	/// </summary>
	/// <param name="srces">軌道物体</param>
	private static void OrbitalCalculation(ref OrbitObject src, float delta_time) {
		src.transform.position += src.velocity_position * delta_time;
		src.transform.rotation *= Quaternion.Slerp(Quaternion.identity, src.velocity_rotation, delta_time);
		src.transform.scale = Vector3.Scale(src.transform.scale, Vector3.Lerp(Vector3.one, src.velocity_scale, delta_time));
	}
}

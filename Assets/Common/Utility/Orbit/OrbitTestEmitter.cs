using UnityEngine;
using System.Collections;

public class OrbitTestEmitter : MonoBehaviour {
	public	OrbitMaterial	m_OrbitMaterial;

	/// <summary>
	/// マウス接触
	/// </summary>
	void OnMouseEnter() {
		var orbit = Orbit.Instantiate(m_OrbitMaterial);
		orbit.velocity_position = new Vector3(0.0f, 10.0f, 0.0f);
		orbit.color = Color.red;
	}
}

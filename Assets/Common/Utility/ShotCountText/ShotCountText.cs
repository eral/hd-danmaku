using UnityEngine;
using System.Collections.Generic;
using System.Linq;

[RequireComponent(typeof(GUIText))]
public class ShotCountText : MonoBehaviour {
	public GUIText		m_Target;
	public LayerMask	m_LayerTarget;
	public string		m_Format = "###0";
	
	/// <summary>
	/// 初回更新前
	/// </summary>
	void Start () {
		if (!m_Target) {
			m_Target = GetComponent<GUIText>();
		}
	}
	
	/// <summary>
	/// 更新
	/// </summary>
	void Update () {
		var count = FindObjectsOfType<GameObject>().Where(x=>0!=(~m_LayerTarget & x.layer)).Count();
		m_Target.text = count.ToString(m_Format);
	}
}

﻿using UnityEngine;
using System.Collections.Generic;
using System.Linq;

[RequireComponent(typeof(UnityEngine.UI.Text))]
public class ShotCountText : MonoBehaviour {
	public UnityEngine.UI.Text	m_Target;
	public LayerMask			m_LayerTarget;
	public string				m_Format = "{0: ###0}<size=10>shots</size>";
	
	/// <summary>
	/// 初回更新前
	/// </summary>
	void Start () {
		if (!m_Target) {
			m_Target = GetComponent<UnityEngine.UI.Text>();
		}
	}
	
	/// <summary>
	/// 更新
	/// </summary>
	void Update () {
		var count = FindObjectsOfType<GameObject>().Where(x=>0!=(m_LayerTarget & (1<<x.layer))).Count();
		count += OrbitInstance.Instantiate().GetOrbitCount();
		m_Target.text = string.Format(m_Format, count);
	}
}

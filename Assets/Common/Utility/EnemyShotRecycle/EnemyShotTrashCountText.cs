using UnityEngine;
using System.Collections.Generic;
using System.Linq;

[RequireComponent(typeof(GUIText))]
public class EnemyShotTrashCountText : MonoBehaviour {
	public GUIText		m_Target;
	public LayerMask	m_LayerTarget;
	public string		m_Format = "{0: ###0}<size=10>trashes</size>";
	
	private Transform m_EnemyShotTrash = null;
	
	/// <summary>
	/// 初回更新前
	/// </summary>
	void Start () {
		if (!m_Target) {
			m_Target = GetComponent<GUIText>();
		}
		var enemy_shot_trash = GameObject.FindGameObjectWithTag("EnemyShotTrash");
		if (enemy_shot_trash) {
			m_EnemyShotTrash = enemy_shot_trash.transform;
		}
	}
	
	/// <summary>
	/// 更新
	/// </summary>
	void Update () {
		var count = m_EnemyShotTrash.childCount;
		count += OrbitInstance.Instantiate().GetTrashCount();
		m_Target.text = string.Format(m_Format, count);
	}
}

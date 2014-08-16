using UnityEngine;
using System.Collections.Generic;

public class PlayerAround : MonoBehaviour {
	public PlayerControl	m_PlayerControl;	//プレイヤーコントロール
	
	/// <summary>
	/// 初回更新前
	/// </summary>
	void Start() {
		if (!m_PlayerControl) {
			m_PlayerControl = GetComponentInParent<PlayerControl>();
		} else {
			enabled = false;
		}
	}
	
	/// <summary>
	/// トリガー衝突開始
	/// </summary>
	/// <param name="other">衝突対象</param>
	void OnTriggerEnter2D(Collider2D other) {
		m_PlayerControl.OnTriggerEnter2DAround(other);
	}
}

using UnityEngine;
using System.Collections;
using Swizzle;

public class HormingToPlayerTag : MonoBehaviour {
						public Rigidbody2D	m_Rigidbody2D	= null;	//制御するRigidbody2D
	[PositiveNumber]	public float		m_ShotSpeed		= 0.0f;	//発射速度(px/秒)

	private Transform	m_Transform = null;
	private Transform	m_PlayerTransform = null;
	private int			m_UpdateCount = 0;

	/// <summary>
	/// 初回更新前
	/// </summary>
	void Start() {
		m_Transform = transform;
		var player_game_object = GameObject.FindGameObjectWithTag("Player");
		if (player_game_object) {
			m_PlayerTransform = player_game_object.transform;
		}
		if (!m_Rigidbody2D) {
			m_Rigidbody2D = GetComponent<Rigidbody2D>();
		}
		if (m_ShotSpeed <= 0.0f) {
			m_ShotSpeed = m_Rigidbody2D.velocity.magnitude;
		}
	}

	/// <summary>
	/// 更新
	/// </summary>
	void Update() {
		if (0 == m_UpdateCount++) {
			var speed_2d = (m_PlayerTransform.position.xy() - m_Transform.position.xy()).normalized * m_ShotSpeed;
			m_Rigidbody2D.velocity = speed_2d;
		}
		m_UpdateCount %= 4;
	}
}

using UnityEngine;
using System.Collections.Generic;

[RequireComponent(typeof(PlayerScore))]
public class PlayerControl : MonoBehaviour {
						public PlayerScore	m_Score;						//スコア
	[PositiveNumber]	public float		m_MoveSpeed			= 200.0f;	//移動速度
						public GameObject	m_ShotPrefab;					//ショット
	[SmallInt]			public SmallInt		m_ShotTimer;					//ショット早度・カウンター
	[PositiveNumber]	public float		m_ShotSpeed			= 2000.0f;	//ショット速度
						public Vector3[]	m_ShotStartPosition	= new Vector3[0];

	private int	m_LayerFlagEnemy;
	private int	m_LayerFlagEnemyShot;
	private int	m_LayerFlagItem;
	
	/// <summary>
	/// 生成
	/// </summary>
	void Awake() {
		m_LayerFlagEnemy		= LayerMask.NameToLayer("Enemy");
		m_LayerFlagEnemyShot	= LayerMask.NameToLayer("EnemyShot");
		m_LayerFlagItem			= LayerMask.NameToLayer("Item");

		m_ShotTimer.SetValueRange(49, 0, 50);
	}
	
	/// <summary>
	/// 初回更新前
	/// </summary>
	void Start() {
		if (null == m_ShotPrefab) {
			enabled = false;
			return;
		}
		if (null == m_Score) {
			m_Score = GetComponent<PlayerScore>();
		}
		m_ShotStartPosition = new[]{new Vector3(  8.0f, 12.0f, 0.0f)
									, new Vector3( -8.0f, 12.0f, 0.0f)
									, new Vector3( 24.0f,  0.0f, 0.0f)
									, new Vector3(-24.0f,  0.0f, 0.0f)
									};
	}
	
	/// <summary>
	/// 更新
	/// </summary>
	void Update() {
		Move_();
		ShotUpdate_();
	}
	
	/// <summary>
	/// トリガー衝突開始
	/// </summary>
	/// <param name="other">衝突対象</param>
	void OnTriggerEnter2D(Collider2D other) {
		var target_layer = other.gameObject.layer;
		if (0 != (m_LayerFlagEnemyShot & target_layer)) {
			//敵弾
			Destroy(other.gameObject);
		} else if (0 != (m_LayerFlagEnemy & target_layer)) {
			//敵
		} else if (0 != (m_LayerFlagItem & target_layer)) {
			//アイテム
			Destroy(other.gameObject);
		}
	}
	
	/// <summary>
	/// 周辺トリガー衝突開始
	/// </summary>
	/// <param name="other">衝突対象</param>
	public void OnTriggerEnter2DAround(Collider2D other) {
		var target_layer = other.gameObject.layer;
		if (0 != (m_LayerFlagEnemyShot & target_layer)) {
			//敵弾
			m_Score.m_Point += m_Score.m_Graze * 10; //得点加算
			++m_Score.m_Graze;
		}
	}
	
	/// <summary>
	/// 移動
	/// </summary>
	private void Move_() {
		float x = Input.GetAxisRaw("X");
		float y = Input.GetAxisRaw("Y");
		if ((0.0f != x) || (0.0f != y)) {
			Vector3 pos = transform.position;
			transform.position = new Vector3(pos.x + x * m_MoveSpeed * Time.deltaTime
											, pos.y + y * m_MoveSpeed * Time.deltaTime
											, pos.z
											);
		}
	}
	
	/// <summary>
	/// ショット更新
	/// </summary>
	private void ShotUpdate_() {
		if (Input.GetButton("Shot")) {
			SmallInt shot_timer_next = m_ShotTimer + (int)(Time.deltaTime * 1000.0f);
			if (shot_timer_next < m_ShotTimer) {
				//発射
				Shot_();
			}
			m_ShotTimer = shot_timer_next;
		} else if (Input.GetButtonUp("Shot")) {
			m_ShotTimer.value = m_ShotTimer.max - 1;
		}
	}
	
	/// <summary>
	/// ショット
	/// </summary>
	private void Shot_() {
		foreach (var start_pos in m_ShotStartPosition) {
			GameObject shot = (GameObject)Instantiate(m_ShotPrefab
													, transform.position + start_pos
													, Quaternion.identity
													);
			shot.rigidbody2D.velocity = new Vector2(0.0f, m_ShotSpeed);
		}
	}
}

using UnityEngine;
using System.Collections.Generic;

[RequireComponent(typeof(PlayerScore))]
public class PlayerControl : MonoBehaviour {
						public PlayerScore		m_Score;							//スコア
	[PositiveNumber]	public float			m_MoveSpeed				= 200.0f;	//移動速度
						public OrbitMaterial	m_ShotOrbitMaterial;				//ショット
	[SmallInt]			public SmallInt			m_ShotTimer;						//ショット早度・カウンター
	[PositiveNumber]	public float			m_ShotSpeed				= 2000.0f;	//ショット速度
						public Vector3[]		m_ShotStartPosition		= new Vector3[0];
						public GameObject		m_BombPrefab;						//ボム用プレファブ
						public BombControl		m_BombControl;						//ボム

	private	Transform m_Transform;
	private int	m_LayerFlagEnemy;
	private int	m_LayerFlagEnemyShot;
	private int	m_LayerFlagItem;
	
	/// <summary>
	/// 生成
	/// </summary>
	void Awake() {
		m_Transform = transform;
		m_LayerFlagEnemy		= LayerMask.NameToLayer("Enemy");
		m_LayerFlagEnemyShot	= LayerMask.NameToLayer("EnemyShot");
		m_LayerFlagItem			= LayerMask.NameToLayer("Item");

		m_ShotTimer.SetValueRange(49, 0, 50);
	}
	
	/// <summary>
	/// 初回更新前
	/// </summary>
	void Start() {
		if (null == m_ShotOrbitMaterial) {
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
		BombUpdate_();
	}
	
	/// <summary>
	/// トリガー衝突開始
	/// </summary>
	/// <param name="other">衝突対象</param>
	void OnTriggerEnter2D(Collider2D other) {
		var target_layer = other.gameObject.layer;
		if (m_LayerFlagEnemyShot == target_layer) {
			//敵弾
			other.SendMessage("OnBecameInvisible");
			//Destroy(other.gameObject);
		} else if (m_LayerFlagEnemy == target_layer) {
			//敵
		} else if (m_LayerFlagItem == target_layer) {
			//アイテム
			other.SendMessage("OnBecameInvisible");
			//Destroy(other.gameObject);
		}
	}
	
	/// <summary>
	/// 周辺トリガー衝突開始
	/// </summary>
	/// <param name="other">衝突対象</param>
	public void OnTriggerEnter2DAround(Collider2D other) {
		var target_layer = other.gameObject.layer;
		if (m_LayerFlagEnemyShot == target_layer) {
			//敵弾
			m_Score.m_Point += m_Score.m_Graze * 10; //得点加算
			++m_Score.m_Graze;
		}
	}
	
	/// <summary>
	/// 軌道物体衝突開始
	/// </summary>
	/// <param name="other">衝突対象</param>
	public void OnOrbitEnter(Orbit orbit) {
		//敵弾
		Orbit.Destory(orbit);
	}
	
	/// <summary>
	/// 周辺軌道物体衝突開始
	/// </summary>
	/// <param name="other">衝突対象</param>
	public void OnOrbitEnterAround(Orbit orbit) {
		//敵弾
		m_Score.m_Point += m_Score.m_Graze * 10; //得点加算
		++m_Score.m_Graze;
	}
	
	/// <summary>
	/// 移動
	/// </summary>
	private void Move_() {
		float x = Input.GetAxisRaw("X");
		float y = Input.GetAxisRaw("Y");
		if ((0.0f != x) || (0.0f != y)) {
			Vector3 pos = m_Transform.position;
			m_Transform.position = new Vector3(pos.x + x * m_MoveSpeed * Time.deltaTime
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
			var shot = Orbit.Instantiate(m_ShotOrbitMaterial);
			shot.position = m_Transform.position + start_pos;
			shot.rotation = Quaternion.identity;
			shot.velocity_position = new Vector2(0.0f, m_ShotSpeed);
		}
	}
	
	/// <summary>
	/// ボム更新
	/// </summary>
	private void BombUpdate_() {
		if (Input.GetButton("Bomb")) {
			if ((0 < m_Score.m_Bomb) && (null == m_BombControl)) {
				--m_Score.m_Bomb;
				Bomb_();
			}
		}
	}
	
	/// <summary>
	/// ボム
	/// </summary>
	private void Bomb_() {
		var bomb = (GameObject)Instantiate(m_BombPrefab, m_Transform.position, m_Transform.rotation);
		bomb.transform.parent = m_Transform;
		m_BombControl = bomb.GetComponent<BombControl>();
		m_BombControl.m_PlayerControl = this;
	}
	
	/// <summary>
	/// ボム終了コールバック
	/// </summary>
	public void BombEndCb() {
		m_BombControl = null;
	}
}

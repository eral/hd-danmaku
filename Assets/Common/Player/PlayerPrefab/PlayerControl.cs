using UnityEngine;
using System.Collections.Generic;

public class PlayerControl : MonoBehaviour {
	public float		MoveSpeed = 200.0f;	//移動速度
	public GameObject	ShotPrefab;			//ショット
	[SmallInt]
	public SmallInt		ShotTimer;				//ショット速度・カウンター
	public float		ShotSpeed = 2000.0f;	//移動速度
	public Vector3[]	ShotStartPosition = new Vector3[0];
	
	/// <summary>
	/// 生成
	/// </summary>
	void Awake() {
		ShotTimer.SetValueRange(49, 0, 50);
	}
	
	/// <summary>
	/// 初回更新前
	/// </summary>
	void Start() {
		ShotStartPosition = new[]{new Vector3(  8.0f, 12.0f, 0.0f)
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
		Shot_();
	}
	
	/// <summary>
	/// 移動
	/// </summary>
	private void Move_() {
		float x = Input.GetAxisRaw("X");
		float y = Input.GetAxisRaw("Y");
		if ((0.0f != x) || (0.0f != y)) {
			Vector3 pos = transform.position;
			transform.position = new Vector3(pos.x + x * MoveSpeed * Time.deltaTime
											, pos.y + y * MoveSpeed * Time.deltaTime
											, pos.z
											);
		}
	}
	
	/// <summary>
	/// ショット
	/// </summary>
	private void Shot_() {
		if (Input.GetButton("Shot")) {
			SmallInt shot_timer_next = ShotTimer + (int)(Time.deltaTime * 1000.0f);
			if (shot_timer_next < ShotTimer) {
				//玉発射
				foreach (var start_pos in ShotStartPosition) {
					GameObject shot = (GameObject)Instantiate(ShotPrefab
															, transform.position + start_pos
															, Quaternion.identity
															);
					shot.rigidbody2D.velocity = new Vector2(0.0f, ShotSpeed);
				}
			}
			ShotTimer = shot_timer_next;
		} else if (Input.GetButtonUp("Shot")) {
			ShotTimer.value = ShotTimer.max - 1;
		}
	}
}

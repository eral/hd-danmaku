using UnityEngine;
using System.Collections;
using System.Linq;

public class EnemyShotEmitter : MonoBehaviour {
							public GameObject	m_CopySource;					//コピー元オブジェクト
	[Range(0.0f, 3600.0f)]	public float		m_Speed			= 100.0f;		//発射速度(px/秒)
	[Range(0.0f, 3600)]		public float		m_ReloadSecond	= 0.25f;		//発射間隔(秒)
							public Color		m_Color			= Color.black;	//色
							public int			m_WayCount		= 1;			//n方向弾
	[Range(0.0f, 360.0f)]	public float		m_WayAngle		= 0.0f;			//扇角度
	
	private float reload_timer = 0.0f;
	
	/// <summary>
	/// 初回更新前
	/// </summary>
	void Start() {
		reload_timer = 0.0f;
	}
	
	/// <summary>
	/// 更新
	/// </summary>
	void Update() {
		if (null == m_CopySource) {
			enabled = false;
			return;
		}
		ShotUpdate_();
	}
	
	/// <summary>
	/// ショット更新
	/// </summary>
	private void ShotUpdate_() {
		if (0 < m_ReloadSecond) {
			reload_timer += Time.deltaTime;
			if (m_ReloadSecond <= reload_timer) {
				//発射
				if (m_WayCount < 2) {
					OneShot_();
				} else {
					WayShot_();
				}
				reload_timer = reload_timer % m_ReloadSecond;
			}
		}
	}
	
	/// <summary>
	/// n方向弾ショット
	/// </summary>
	private void WayShot_() {
		Quaternion start_rotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, -m_WayAngle * 0.25f));
		Quaternion end_rotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, m_WayAngle * 0.25f));
		foreach(var rotation in Enumerable.Range(0, m_WayCount)
											.Select(x=>(float)x / (float)(m_WayCount - 1))
											.Select(x=>Quaternion.Lerp(start_rotation, end_rotation, x))
											.Select(x=>x * x)
											.Select(x=>transform.rotation * x)) {
			Shot_(rotation);
		}
	}
	
	/// <summary>
	/// 単体ショット
	/// </summary>
	private void OneShot_() {
		Shot_(transform.rotation);
	}
	
	/// <summary>
	/// ショット
	/// </summary>
	/// <param name="rotation">方向(Quaternion.identityが上)</param>
	private void Shot_(Quaternion rotation) {
		GameObject shot = (GameObject)Instantiate(m_CopySource
												, transform.position
												, rotation
												);
		var speed = rotation * (new Vector2(0.0f, m_Speed));
		shot.rigidbody2D.velocity = speed;
		
		var sprite_renderer = shot.GetComponent<SpriteRenderer>();
		if (null != sprite_renderer) {
			sprite_renderer.color = m_Color;
		}
	}
}

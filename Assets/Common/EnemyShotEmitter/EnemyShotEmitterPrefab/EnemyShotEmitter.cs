using UnityEngine;
using System.Collections;
using System.Linq;

public class EnemyShotEmitter : MonoBehaviour {
							public OrbitMaterial	m_OrbitMaterial;					//軌道マテリアル
	[PositiveNumber]		public float			m_ShotSpeed			= 100.0f;		//発射速度(px/秒)
	[Range(0.0f, 180.0f)]	public float			m_ShotCount			= 4.0f;			//発射数(発/秒)
							public Color			m_Color				= Color.black;	//色
							public int				m_WayCount			= 1;			//n方向弾
	[Range(0.0f, 360.0f)]	public float			m_WayAngle			= 0.0f;			//扇角度
							public bool				m_RegularAngleLimit	= true;			//正多角形角度制限(true:なら360で全方位弾に為る)
	
	private float m_ReloadTimer = 0.0f;
	
	/// <summary>
	/// 初回更新前
	/// </summary>
	void Start() {
		m_ReloadTimer = 0.0f;
	}
	
	/// <summary>
	/// 更新
	/// </summary>
	void Update() {
		if (null == m_OrbitMaterial) {
			enabled = false;
			return;
		}
		ShotUpdate_();
	}
	
	/// <summary>
	/// ショット更新
	/// </summary>
	private void ShotUpdate_() {
		if (0 < m_ShotCount) {
			m_ReloadTimer += Time.deltaTime;

			var reload_second = 1.0f / m_ShotCount;
			if (reload_second <= m_ReloadTimer) {
				//発射
				if (m_WayCount < 2) {
					OneShot_();
				} else {
					WayShot_();
				}
				m_ReloadTimer = m_ReloadTimer % reload_second;
			}
		}
	}
	
	/// <summary>
	/// n方向弾ショット
	/// </summary>
	private void WayShot_() {
		var angle = m_WayAngle;
		if (m_RegularAngleLimit) {
			var delta_angle = 360.0f / m_WayCount;
			if (360.0f < (angle + delta_angle)) {
				angle = 360.0f - delta_angle;
			}
		}
		Quaternion start_rotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, -angle * 0.25f));
		Quaternion end_rotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, angle * 0.25f));
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
		Orbit orbit = CreateShot_(transform.position, rotation);
		orbit.color = m_Color;
	}
	
	/// <summary>
	/// ショット構築
	/// </summary>
	/// <returns>ショット</returns>
	/// <param name="position">位置</param>
	/// <param name="rotation">方向(Quaternion.identityが上)</param>
	private Orbit CreateShot_(Vector3 position, Quaternion rotation) {
		Orbit result = Orbit.Instantiate(m_OrbitMaterial);
		result.position = position;
		result.velocity_position = rotation * (new Vector3(0.0f, m_ShotSpeed, 0.0f));
		return result;
	}
}

using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using Swizzle;

[RequireComponent(typeof(OrbitMaterial))]
public class OrbitUpdater : MonoBehaviour {
	public OrbitMaterial	m_OrbitMaterial;
	public PlayerControl	m_Player;
	public PlayerAround		m_PlayerAround;

	/// <summary>
	/// 生成
	/// </summary>
	void Awake() {
		m_OrbitMaterial = GetComponent<OrbitMaterial>();
	}
	
	/// <summary>
	/// 初回更新前
	/// </summary>
	void Start() {
		var player_game_object = GameObject.FindGameObjectWithTag("Player");
		if (player_game_object) {
			m_Player = player_game_object.GetComponent<PlayerControl>();
		}
		var player_around_transform = player_game_object.transform.FindChild("PlayerAround");
		if (player_around_transform) {
			m_PlayerAround = player_around_transform.GetComponent<PlayerAround>();
		}
	}
	
	/// <summary>
	/// 更新
	/// </summary>
	void Update() {
		for (int i = 0, i_max = m_OrbitMaterial.m_OrbitObjects.Length; i < i_max; ++i) {
			if (m_OrbitMaterial.m_OrbitObjects[i].valid) {
				OrbitalCalculation(ref m_OrbitMaterial.m_OrbitObjects[i], Time.deltaTime);

				if (IsInvisible(m_OrbitMaterial.m_OrbitObjects[i])) {
					m_OrbitMaterial.FreeOrbitIndices(i);
				} else if (IsEnterOntoPlayerAround(m_OrbitMaterial.m_OrbitObjects[i])) {
					var orbit = Orbit.Instantiate(m_OrbitMaterial, i);
					if (0 == (m_OrbitMaterial.m_OrbitObjects[i].user_flag & 0x01)) {
						m_PlayerAround.OnOrbitEnter(orbit);
						m_OrbitMaterial.m_OrbitObjects[i].user_flag |= 0x01;
					}

					if (IsEnterOntoPlayer(m_OrbitMaterial.m_OrbitObjects[i])) {
						m_Player.OnOrbitEnter(orbit);
					}
				}
			}
		}
	}
	
	/// <summary>
	/// 軌道計算
	/// </summary>
	/// <param name="srces">軌道物体</param>
	private static void OrbitalCalculation(ref OrbitObject src, float delta_time) {
		src.transform.position += src.velocity_position * delta_time;
		src.transform.rotation *= Quaternion.Slerp(Quaternion.identity, src.velocity_rotation, delta_time);
		src.transform.scale = Vector3.Scale(src.transform.scale, Vector3.Lerp(Vector3.one, src.velocity_scale, delta_time));
	}

	/// <summary>
	/// 画面外判定
	/// </summary>
	/// <param name="orbit">軌道物体</param>
	/// <returns>true:画面外, false:画面内</returns>
	private bool IsInvisible(OrbitObject orbit) {
		Vector3 position = orbit.position;

		bool result = false;
		if (position.x < -640.0f) {
			result = true;
		} else if (640.0f < position.x) {
			result = true;
		} else if (position.y < -360.0f) {
			result = true;
		} else if (360.0f < position.y) {
			result = true;
		} else {
			//範囲内
		}
		return result;
	}

	/// <summary>
	/// プレイヤー接触判定
	/// </summary>
	/// <param name="orbit">軌道物体</param>
	/// <returns>true:接触, false:未接触</returns>
	private bool IsEnterOntoPlayer(OrbitObject orbit) {
		var distance = m_Player.transform.position - (orbit.position + orbit.collider_bounds.center);
		var extents = m_Player.collider2D.bounds.extents + orbit.collider_bounds.extents;
			
		bool result = true;
		if (extents.x < Mathf.Abs(distance.x)) {
			result = false;
		} else if (extents.y < Mathf.Abs(distance.y)) {
			result = false;
		} else {
			//範囲内
		}
		return result;
	}

	/// <summary>
	/// プレイヤー接触判定
	/// </summary>
	/// <param name="orbit">軌道物体</param>
	/// <returns>true:接触, false:未接触</returns>
	private bool IsEnterOntoPlayerAround(OrbitObject orbit) {
		var distance = m_PlayerAround.transform.position - (orbit.position + orbit.collider_bounds.center);
		var extents = m_PlayerAround.collider2D.bounds.extents + orbit.collider_bounds.extents;
			
		bool result = true;
		if (extents.x < Mathf.Abs(distance.x)) {
			result = false;
		} else if (extents.y < Mathf.Abs(distance.y)) {
			result = false;
		} else {
			//範囲内
		}
		return result;
	}
}

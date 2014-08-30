using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using Swizzle;

[RequireComponent(typeof(OrbitRenderer))]
public class OrbitUpdater : MonoBehaviour {
	public OrbitRenderer	m_OrbitRenderer;
	public PlayerControl	m_Player;
	public PlayerAround		m_PlayerAround;
	public Bounds			m_CameraViewBounds;

	/// <summary>
	/// 生成
	/// </summary>
	void Awake() {
		m_OrbitRenderer = GetComponent<OrbitRenderer>();
	}
	
	/// <summary>
	/// 初回更新前
	/// </summary>
	void Start() {
		if (!m_Player) {
			var player_game_object = GameObject.FindGameObjectWithTag("Player");
			if (player_game_object) {
				m_Player = player_game_object.GetComponent<PlayerControl>();
			}
			if (!m_PlayerAround) {
				var player_around_transform = player_game_object.transform.FindChild("PlayerAround");
				if (player_around_transform) {
					m_PlayerAround = player_around_transform.GetComponent<PlayerAround>();
				}
			}
		}
		{
			var camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
			var camera_position = camera.transform.position;
			Vector2 camera_size;
			if (camera.isOrthoGraphic) {
				//正射影
				camera_size.y = camera.orthographicSize;
			} else {
				//透視射影
				camera_size.y = Mathf.Tan(camera.fieldOfView * Mathf.Deg2Rad) * Mathf.Abs(camera_position.z);
			}
			camera_size.x = camera_size.y * camera.aspect;
			
			m_CameraViewBounds = new Bounds(new Vector3(camera_position.x, camera_position.y, 0.0f)
											, new Vector3(camera_size.x * 2.0f, camera_size.y * 2.0f, float.Epsilon)
											);
		}
	}
	
	/// <summary>
	/// 更新
	/// </summary>
	void Update() {
		for (int i = 0, i_max = m_OrbitRenderer.m_OrbitObjects.Length; i < i_max; ++i) {
			if (m_OrbitRenderer.m_OrbitObjects[i].valid) {
				OrbitalCalculation(ref m_OrbitRenderer.m_OrbitObjects[i], Time.deltaTime);

				if (IsInvisible(m_OrbitRenderer.m_OrbitObjects[i])) {
					//画面外なら
					//破棄
					m_OrbitRenderer.m_OrbitObjects[i].Init(null);
					m_OrbitRenderer.FreeOrbitIndices(i);
				} else if (IsEnterOntoPlayerAround(m_OrbitRenderer.m_OrbitObjects[i])) {
					//周辺接触なら
					var orbit = new Orbit(m_OrbitRenderer, i);
					//かすり処理
					if (0 == (m_OrbitRenderer.m_OrbitObjects[i].user_flag & 0x01)) {
						m_PlayerAround.OnOrbitEnter(orbit);
						m_OrbitRenderer.m_OrbitObjects[i].user_flag |= 0x01;
					}

					if (IsEnterOntoPlayer(m_OrbitRenderer.m_OrbitObjects[i])) {
						//接触なら
						//接触処理
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
		if (!src.move_only) {
			src.transform.rotation *= Quaternion.Slerp(Quaternion.identity, src.velocity_rotation, delta_time);
			src.transform.scale = Vector3.Scale(src.transform.scale, Vector3.Lerp(Vector3.one, src.velocity_scale, delta_time));
		}
	}

	/// <summary>
	/// 画面外判定
	/// </summary>
	/// <param name="orbit">軌道物体</param>
	/// <returns>true:画面外, false:画面内</returns>
	private bool IsInvisible(OrbitObject orbit) {
		var distance = m_CameraViewBounds.center - orbit.position;
		var extents = m_CameraViewBounds.extents + orbit.draw_bounds.extents;

		bool result = false;
		if (extents.x < Mathf.Abs(distance.x)) {
			result = true;
		} else if (extents.y < Mathf.Abs(distance.y)) {
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

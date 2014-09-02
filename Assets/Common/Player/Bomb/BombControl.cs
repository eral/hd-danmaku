using UnityEngine;
using System.Linq;
using Swizzle;

[RequireComponent(typeof(Collider2D)), RequireComponent(typeof(Animator))]
public class BombControl : MonoBehaviour {
	public PlayerControl	m_PlayerControl;
	public CircleCollider2D	m_Collider;
	public OrbitMaterial	m_Point;

	private Transform	m_Transform;
	private bool		m_AnimationEnd = false;
	
	/// <summary>
	/// 生成
	/// </summary>
	void Awake() {
		m_Collider = GetComponent<CircleCollider2D>();
		m_Transform = transform;
	}
	
	/// <summary>
	/// 破棄
	/// </summary>
	void OnDestroy() {
		m_PlayerControl.BombEndCb();
	}
	
	/// <summary>
	/// 更新
	/// </summary>
	void Update() {
		var enemy_shots = Orbit.GetInstanceList().Where(x=>OrbitMaterial.Tag.EnemyShot == x.tag);
		foreach (var enemy_shot in enemy_shots) {
			if (IsHit(enemy_shot, m_Collider, m_Transform) || m_AnimationEnd) {
				//当たり範囲に接触しているか、アニメーションが終了しているなら
				//アイテムに変えて、プレイヤーホーミング化
				enemy_shot.ChangeMaterial(m_Point);
				enemy_shot.velocity_position = new Vector3(1000.0f, 0.0f, 0.0f);
				enemy_shot.player_homing = true;
			}
		}
		if (m_AnimationEnd) {
			Destroy(gameObject);
		}
	}
	
	/// <summary>
	/// アニメーション終了コールバック
	/// </summary>
	void AnimationEndCb() {
		m_AnimationEnd = true;
	}

	private static bool IsHit(Orbit orbit, CircleCollider2D circle_collider_2d, Transform transform) {
		//HACK: 回転未考慮
		var distance_2d = transform.position.xy() + circle_collider_2d.center.xy() - orbit.position.xy();
		var orbit_extents_2d = Vector2.Scale(orbit.collider_bounds.extents.xy(), orbit.scale.xy());
		var collider_extents = circle_collider_2d.radius * Mathf.Max(transform.lossyScale.x, transform.lossyScale.y);
		var sqr_extents = orbit_extents_2d.sqrMagnitude + collider_extents * collider_extents;
		return distance_2d.sqrMagnitude <= sqr_extents;
	}
}

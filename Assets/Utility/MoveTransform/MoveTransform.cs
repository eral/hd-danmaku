using UnityEngine;
using System.Collections;

public class MoveTransform : MonoBehaviour {
	public enum Timing {
		Null,
		Update,
		LateUpdate,
	}
						public	Timing		m_Timing		= Timing.Update;
						public	Vector3		m_PositionSpeed	= Vector3.zero;			//移動速度
	[QuaternionEuler]	public	Quaternion	m_RotationSpeed	= Quaternion.identity;	//回転速度
						public	Vector3		m_ScaleSpeed	= Vector3.one;			//拡縮速度
	
	private	Transform transform_;
	
	/// <summary>
	/// 初回更新前
	/// </summary>
	void Start() {
		transform_ = transform;
	}
	
	/// <summary>
	/// 更新
	/// </summary>
	void Update() {
		if (Timing.Update == m_Timing) {
			Apply_();
		}
	}
	
	/// <summary>
	/// 初回更新前
	/// </summary>
	void LateUpdate() {
		if (Timing.Update == m_Timing) {
			Apply_();
		}
	}
	
	/// <summary>
	/// 適用
	/// </summary>
	void Apply_() {
		transform_.localPosition += m_PositionSpeed * Time.deltaTime;
		transform_.localRotation *= Quaternion.Slerp(Quaternion.identity, m_RotationSpeed, Time.deltaTime);
		transform_.localScale = Vector3.Scale(transform_.localScale, Vector3.Lerp(Vector3.one, m_ScaleSpeed, Time.deltaTime));
	}
}

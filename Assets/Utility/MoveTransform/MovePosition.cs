using UnityEngine;
using System.Collections;

public class MovePosition : MonoBehaviour {
	public	Vector3		m_PositionSpeed	= Vector3.zero;	//移動速度
	
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
		Apply_();
	}
	
	/// <summary>
	/// 適用
	/// </summary>
	void Apply_() {
		transform_.localPosition += m_PositionSpeed * Time.deltaTime;
	}
}

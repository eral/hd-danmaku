using UnityEngine;

public class QuaternionEulerAttribute : PropertyAttribute {
	public Vector3		value = Vector3.one; //Quaternion.identityでは無い値
	public Quaternion	last = Quaternion.identity;
	
	/// <summary>
	/// コンストラクタ
	/// </summary>
	public QuaternionEulerAttribute() {
	}
}

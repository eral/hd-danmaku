using UnityEngine;
using System.Collections.Generic;

public class PositiveNumberAttribute : PropertyAttribute {
	private bool enable_zero_; //零を許容するか(true:許容する,false:許容しない)
	
	/// <summary>
	/// コンストラクタ
	/// </summary>
	/// <param name="disable_zero">零を許容するか(true:許容する,false:許容しない)</param>
	public PositiveNumberAttribute(bool enable_zero = true) {
		enable_zero_ = enable_zero;
	}
	
	/// <summary>
	/// 零を許容するか確認プロパティ
	/// </summary>
	/// <value>零を許容するか(true:許容する,false:許容しない)</value>
	public bool enable_zero {
		get{return enable_zero_;}
	}
}

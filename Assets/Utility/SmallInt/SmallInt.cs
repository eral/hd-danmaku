using System.Collections.Generic;

[System.Serializable]
public struct SmallInt {
	public int value_;	//<値
	public int min_;	//<最小値(含む)
	public int max_;	//<最大値(含まず)
	private uint uvalue_	{get{return (uint)value_;} set{value_ = (int)value;}}	//<uint型の値
	private bool is_range_	{get{return min_<max_;}}								//falseの場合無制限
	private uint range_		{get{return (uint)max_-(uint)min_;}}					//無制限の場合は0
	
	/// <summary>
	/// 値プロパティ
	/// </summary>
	/// <value>値</value>
	public int value {
		get{return value_;}
		set{SetValue(value);}
	}
	
	/// <summary>
	/// 最小値プロパティ
	/// </summary>
	/// <value>最小値(含む)</value>
	public int min {
		get{return min_;}
		set{SetRange(max_, value);}
	}
	
	/// <summary>
	/// 最大値プロパティ
	/// </summary>
	/// <value>最大値(含まず)</value>
	public int max {
		get{return max_;}
		set{SetRange(value, min_);}
	}
	
	/// <summary>
	/// 値指定コンストラクタ
	/// </summary>
	/// <param name="value">値</param>
	/// <remarks>範囲制限は行われません</remarks>
	public SmallInt(int value): this(value, 0, 0) {
	}
	
	/// <summary>
	/// 最大制限コンストラクタ
	/// </summary>
	/// <param name="value">値</param>
	/// <param name="max">最大値(含まず)</param>
	public SmallInt(int value, int max) : this(value, 0, max) {
	}
	
	/// <summary>
	/// 範囲制限コンストラクタ
	/// </summary>
	/// <param name="value">値</param>
	/// <param name="min">最小値(含む)</param>
	/// <param name="max">最大値(含まず)</param>
	public SmallInt(int value, int min, int max) {
		if (max < min) {
			throw new System.ArgumentOutOfRangeException();
		}
		value_ = value;
		min_ = min;
		max_ = max;
	}
	
	/// <summary>
	/// 値設定
	/// </summary>
	/// <param name="value">値</param>
	/// <remarks>
	/// 範囲制限は変更されません。
	/// </remarks>
	public void SetValue(int value) {
		if (is_range_) {
			value_ = Normalize_(value, min_, max_);
		} else {
			value_ = value;
		}
	}
	
	/// <summary>
	/// 範囲制限設定
	/// </summary>
	/// <param name="value">値</param>
	/// <remarks>
	/// 範囲が変更された結果、値が範囲外に出た場合は範囲内に丸められます。
	/// </remarks>
	public void SetRange(int min, int max) {
		this.SetValueRange(value_, min, max);
	}
	
	/// <summary>
	/// 値設定
	/// </summary>
	/// <param name="value">値</param>
	/// <param name="min">最小値(含む)</param>
	/// <param name="max">最大値(含まず)</param>
	public void SetValueRange(int value, int min, int max) {
		if (max < min) {
			throw new System.ArgumentOutOfRangeException();
		}
		value_ = value;
		min_ = min;
		max_ = max;
	}
	
	/// <summary>
	/// intキャスト
	/// </summary>
	public static implicit operator int(SmallInt src) {
		return src.value_;
	}
	
	/// <summary>
	/// 正符号
	/// </summary>
	public static SmallInt operator+(SmallInt src) {
		return src;
	}
	/// <summary>
	/// 負符号
	/// </summary>
	public static SmallInt operator-(SmallInt src) {
		src.value_ = -src.value_;
		if (src.is_range_) {
			src.value_ = Normalize_(src.value_, src.min_, src.max_);
		}
		return src;
	}
	
	/// <summary>
	/// インクリメント
	/// </summary>
	public static SmallInt operator ++(SmallInt src) {
		++src.value_;
		if ((src.max_ <= src.value_) && src.is_range_) {
			src.uvalue_ -= src.range_;
		}
		return src;
	}
	/// <summary>
	/// デクリメント
	/// </summary>
	public static SmallInt operator --(SmallInt src) {
		--src.value_;
		if ((src.value_ < src.min_) && src.is_range_) {
			src.uvalue_ += src.range_;
		}
		return src;
	}
	
	/// <summary>
	/// 加算
	/// </summary>
	public static SmallInt operator +(SmallInt lhs, SmallInt rhs) {
		return lhs + rhs.value_;
	}
	public static SmallInt operator +(SmallInt lhs, int rhs) {
		lhs.value_ += rhs;
		if (lhs.is_range_) {
			lhs.value_ = Normalize_(lhs.value_, lhs.min_, lhs.max_);
		}
		return lhs;
	}
	public static SmallInt operator +(int lhs, SmallInt rhs) {
		return rhs + lhs;
	}
	
	/// <summary>
	/// 減算
	/// </summary>
	public static SmallInt operator -(SmallInt lhs, SmallInt rhs) {
		return lhs + -rhs;
	}
	public static SmallInt operator -(SmallInt lhs, int rhs) {
		return lhs + -rhs;
	}
	public static SmallInt operator -(int lhs, SmallInt rhs) {
		return lhs + -rhs;
	}
	
	/// <summary>
	/// 乗算
	/// </summary>
	public static SmallInt operator *(SmallInt lhs, SmallInt rhs) {
		return lhs * rhs.value_;
	}
	public static SmallInt operator *(SmallInt lhs, int rhs) {
		lhs.value_ *= rhs;
		if (lhs.is_range_) {
			lhs.value_ = Normalize_(lhs.value_, lhs.min_, lhs.max_);
		}
		return lhs;
	}
	public static SmallInt operator *(int lhs, SmallInt rhs) {
		return rhs * lhs;
	}
	
	/// <summary>
	/// 除算
	/// </summary>
	public static SmallInt operator /(SmallInt lhs, SmallInt rhs) {
		return lhs / rhs.value_;
	}
	public static SmallInt operator /(SmallInt lhs, int rhs) {
		lhs.value_ /= rhs;
		if (lhs.is_range_) {
			lhs.value_ = Normalize_(lhs.value_, lhs.min_, lhs.max_);
		}
		return lhs;
	}
	public static SmallInt operator /(int lhs, SmallInt rhs) {
		rhs.value_ = lhs / rhs.value_;
		if (rhs.is_range_) {
			rhs.value_ = Normalize_(rhs.value_, rhs.min_, rhs.max_);
		}
		return rhs;
	}
	
	/// <summary>
	/// 剰余
	/// </summary>
	public static SmallInt operator %(SmallInt lhs, SmallInt rhs) {
		return lhs % rhs.value_;
	}
	public static SmallInt operator %(SmallInt lhs, int rhs) {
		lhs.value_ %= rhs;
		if (lhs.is_range_) {
			lhs.value_ = Normalize_(lhs.value_, lhs.min_, lhs.max_);
		}
		return lhs;
	}
	public static SmallInt operator %(int lhs, SmallInt rhs) {
		rhs.value_ = lhs % rhs.value_;
		if (rhs.is_range_) {
			rhs.value_ = Normalize_(rhs.value_, rhs.min_, rhs.max_);
		}
		return rhs;
	}
	
	/// <summary>
	/// 同値比較
	/// </summary>
	public static bool operator ==(SmallInt lhs, SmallInt rhs) {
		return lhs.value_ == rhs.value_;
	}
	public static bool operator ==(SmallInt lhs, int rhs) {
		return lhs.value_ == rhs;
	}
	public static bool operator ==(int lhs, SmallInt rhs) {
		return lhs == rhs.value_;
	}
	
	/// <summary>
	/// 相違比較
	/// </summary>
	public static bool operator !=(SmallInt lhs, SmallInt rhs) {
		return lhs.value_ != rhs.value_;
	}
	public static bool operator !=(SmallInt lhs, int rhs) {
		return lhs.value_ != rhs;
	}
	public static bool operator !=(int lhs, SmallInt rhs) {
		return lhs != rhs.value_;
	}
	
	/// <summary>
	/// 未満比較
	/// </summary>
	public static bool operator <(SmallInt lhs, SmallInt rhs) {
		return lhs.value_ < rhs.value_;
	}
	public static bool operator <(SmallInt lhs, int rhs) {
		return lhs.value_ < rhs;
	}
	public static bool operator <(int lhs, SmallInt rhs) {
		return lhs < rhs.value_;
	}
	/// <summary>
	/// 過剰比較
	/// </summary>
	public static bool operator >(SmallInt lhs, SmallInt rhs) {
		return lhs.value_ > rhs.value_;
	}
	public static bool operator >(SmallInt lhs, int rhs) {
		return lhs.value_ > rhs;
	}
	public static bool operator >(int lhs, SmallInt rhs) {
		return lhs > rhs.value_;
	}
	
	/// <summary>
	/// 同値比較
	/// </summary>
	public override bool Equals(object rhs) {
		bool result = false;
		if (null != rhs) {
			if ( typeof(SmallInt) == rhs.GetType()) {
				SmallInt rhs_detail = (SmallInt)rhs;
				result = (this == rhs_detail);
			} else {
				int rhs_detail = (int)rhs;
				result = (this == rhs_detail);
			}
		}
		return result;
	}
	/// <summary>
	/// ハッシュ取得
	/// </summary>
	public override int GetHashCode() {
		return value_.GetHashCode();
	}
	/// <summary>
	/// 文字列取得
	/// </summary>
	public override string ToString() {
		return value_.ToString() + "[" + min_ + "," + max_ + ")";
	}
	
	/// <summary>
	/// 値を範囲内に移動させる
	/// </summary>
	/// <returns>範囲内の値</returns>
	/// <param name="value">値</param>
	/// <param name="min">最小値(含む)</param>
	/// <param name="max">最大値(含まず)</param>
	private static int Normalize_(int value, int min, int max) {
		if (value < min) {
			uint range = (uint)max - (uint)min;
			uint offset_minus = (uint)min - (uint)value;
			uint goto_range = ((offset_minus / range) + ((0u != (offset_minus % range))? 1u: 0u)) * range;
			value += (int)goto_range;
		} else if (max <= value) {
			uint offset = (uint)value - (uint)min;
			uint range = (uint)max - (uint)min;
			offset %= range;
			value = (int)offset + min;
		}
		return value;
	}
}

[System.Serializable]
public struct UnsupportedLiteralLong {
	public long value;

	public static implicit operator long(UnsupportedLiteralLong src) {
		return src.value;
	}

	public static implicit operator UnsupportedLiteralLong(long src) {
		UnsupportedLiteralLong result;
		result.value = src;
		return result;
	}
}

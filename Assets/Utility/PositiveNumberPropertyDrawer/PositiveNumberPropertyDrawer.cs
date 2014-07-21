using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;

[CustomPropertyDrawer(typeof(PositiveNumberAttribute))]
public class PositiveNumberDrawer : PropertyDrawer {
	
	/// <summary>
	/// GUI描画
	/// </summary>
	/// <param name="position">描画領域</param>
	/// <param name="property">属性を付与した値</param>
	/// <param name="label">ラベル</param>
	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
		var positive_number_attribute = (PositiveNumberAttribute)attribute;
		
		EditorGUI.PropertyField(position, property, label);
		if (GUI.changed) {
			switch (property.propertyType) {
			case SerializedPropertyType.Float:
				if (property.floatValue <= 0.0f) {
					property.floatValue = ((positive_number_attribute.enable_zero)? 0.0f: float.Epsilon);
				}
				break;
			case SerializedPropertyType.Integer:
				if (property.intValue <= 0) {
					property.intValue = ((positive_number_attribute.enable_zero)? 0: 1);
				}
				break;
			}
		}
	}
}
#endif //UNITY_EDITOR

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

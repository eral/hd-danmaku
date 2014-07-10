using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.Reflection;

[CustomPropertyDrawer(typeof(PositiveNumberAttribute))]
public class PositiveNumberDrawer : PropertyDrawer {
	
	/// <summary>
	/// コンストラクタ
	/// </summary>
	public PositiveNumberDrawer() {
	}
	
	/// <summary>
	/// GUI描画
	/// </summary>
	/// <param name="position">描画領域</param>
	/// <param name="property">属性を付与した値</param>
	/// <param name="label">ラベル</param>
	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
		PositiveNumberAttribute positive_number_attribute = (PositiveNumberAttribute)attribute;
		
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

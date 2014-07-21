using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;

[CustomPropertyDrawer(typeof(SmallIntAttribute))]
public class SmallIntPropertyDrawer : PropertyDrawer {
	
	/// <summary>
	/// GUI描画
	/// </summary>
	/// <param name="position">描画領域</param>
	/// <param name="property">属性を付与した値</param>
	/// <param name="label">ラベル</param>
	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
		//var small_int_attribute = (SmallIntAttribute)attribute;
		
		if ("SmallInt" == property.type) {
			var parent_object = property.serializedObject.targetObject;
			var current = (SmallInt)parent_object.GetType().GetField(property.propertyPath).GetValue(parent_object);

			Rect value_position = EditorGUI.PrefixLabel(position, label);
			position.xMax = value_position.x;
			EditorGUI.LabelField(position, label);
			
			float label_width = EditorGUIUtility.labelWidth;
			int indent_level = EditorGUI.indentLevel;
			
			var int_field_width = value_position.width / 3.0f;
			value_position.width = int_field_width;
			EditorGUIUtility.labelWidth = 13.0f;
			EditorGUI.indentLevel = 0;
			var value = EditorGUI.IntField(value_position, new GUIContent("Value"), current.value);
			value_position.x += int_field_width;
			var min = EditorGUI.IntField(value_position, new GUIContent("Min"), current.min);
			value_position.x += int_field_width;
			var max = EditorGUI.IntField(value_position, new GUIContent("Max"), current.max);
			EditorGUIUtility.labelWidth = label_width;
			EditorGUI.indentLevel = indent_level;
			
			if ((value != current.value) || (min != current.min) || (max != current.max)) {
				current.SetValueRange(value, min, max);
				parent_object.GetType().GetField(property.propertyPath).SetValue(parent_object, current);
				EditorUtility.SetDirty(parent_object);
			}
		} else {
			EditorGUI.LabelField(position, label, new GUIContent("This type has not supported."));
		}
	}
}
#endif //UNITY_EDITOR

public class SmallIntAttribute : PropertyAttribute {
}


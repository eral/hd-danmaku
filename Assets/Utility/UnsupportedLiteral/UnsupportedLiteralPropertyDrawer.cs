using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;

[CustomPropertyDrawer(typeof(UnsupportedLiteralAttribute))]
public class UnsupportedLiteralPropertyDrawer : PropertyDrawer {
	
	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
		//var unsupported_literal_attribute = (UnsupportedLiteralAttribute)attribute;
		
		if (SerializedPropertyType.Generic == property.propertyType) {
			if ("UnsupportedLiteralLong" == property.type) {
				OnGUIforLong(position, property, label);
			} else {
				EditorGUI.LabelField(position, label, new GUIContent("This type has not supported."));
			}
		} else {
			EditorGUI.PropertyField(position, property, label);
		}
	}
	
	private void OnGUIforLong(Rect position, SerializedProperty property, GUIContent label) {
		var parent_object = property.serializedObject.targetObject;
		var current = (UnsupportedLiteralLong)parent_object.GetType().GetField(property.propertyPath).GetValue(parent_object);
		
		EditorGUIUtility.LookLikeControls();
		var is_update = false;
		var threshold = int.MaxValue >> 4;
		if ((-threshold <= current.value) && (current.value <= threshold)) {
			var int_value = (int)current.value;
			EditorGUI.BeginChangeCheck();
			var value = (long)EditorGUI.IntField(position, label, int_value);
			if (EditorGUI.EndChangeCheck()) {
				current.value = value;
				is_update = true;
			}
		} else {
			var str_value = current.value.ToString();
			EditorGUI.BeginChangeCheck();
			str_value = EditorGUI.TextField(position, label, str_value);
			long value;
			if (EditorGUI.EndChangeCheck() && long.TryParse(str_value, out value)) {
				current.value = value;
				is_update = true;
			}
		}
		if (is_update) {
			parent_object.GetType().GetField(property.propertyPath).SetValue(parent_object, current);
			EditorUtility.SetDirty(parent_object);
		}
	}
}
#endif

public class UnsupportedLiteralAttribute : PropertyAttribute {
}

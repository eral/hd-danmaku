/*
 * (C) 2014 ERAL
 * Distributed under the Boost Software License, Version 1.0.
 * (See copy at http://www.boost.org/LICENSE_1_0.txt)
 */

using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;

[CustomPropertyDrawer(typeof(EnumMaskAttribute))]
public class EnumMaskPropertyDrawer : PropertyDrawer {
	
	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
		if (SerializedPropertyType.Enum == property.propertyType) {
			var parent_object = property.serializedObject.targetObject;
			var current = parent_object.GetType().GetField(property.propertyPath).GetValue(parent_object);
			EditorGUI.BeginChangeCheck();
			var value = EditorGUI.EnumMaskField(position, label, (System.Enum)current);
			if (EditorGUI.EndChangeCheck()) {
				current = value;
				parent_object.GetType().GetField(property.propertyPath).SetValue(parent_object, current);
			}
		} else {
			EditorGUI.LabelField(position, label, new GUIContent("This type has not supported."));
		}
	}
}
#endif

public class EnumMaskAttribute : PropertyAttribute {
}

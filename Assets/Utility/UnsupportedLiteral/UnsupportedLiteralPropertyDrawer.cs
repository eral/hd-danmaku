/*
 *	(C) 2014 ERAL
 *	Distributed under the Boost Software License, Version 1.0.
 *	(See copy at http://www.boost.org/LICENSE_1_0.txt)
 */

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
		EditorGUI.BeginChangeCheck();
		var value = (long)EditorGUI.IntField(position, label, (int)current.value);
		if (EditorGUI.EndChangeCheck()) {
			current.value = value;
			parent_object.GetType().GetField(property.propertyPath).SetValue(parent_object, current);
			EditorUtility.SetDirty(parent_object);
		}
	}
}
#endif

public class UnsupportedLiteralAttribute : PropertyAttribute {
}

/*
 * (C) 2014 ERAL
 * Distributed under the Boost Software License, Version 1.0.
 * (See copy at http://www.boost.org/LICENSE_1_0.txt)
 */

using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;

[CustomPropertyDrawer(typeof(QuaternionEulerAttribute))]
public class QuaternionEulerPropertyDrawer : PropertyDrawer {
	private Vector3		value	= Vector3.one;
	private Quaternion	last	= Quaternion.identity;

	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
		if (SerializedPropertyType.Quaternion == property.propertyType) {
			EditorGUIUtility.LookLikeControls();
			var is_update = (!last.Equals(property.quaternionValue));
			is_update = is_update || (Quaternion.Euler(value) != last);
			if (is_update) {
				value = property.quaternionValue.eulerAngles;
				last = Quaternion.Euler(value);
			}
			EditorGUI.BeginChangeCheck();
			value = EditorGUI.Vector3Field(position, label, value);
			if (EditorGUI.EndChangeCheck()) {
				last = property.quaternionValue = Quaternion.Euler(value);
			}
		} else {
			EditorGUI.LabelField(position, label, new GUIContent("This type has not supported."));
		}
	}
}
#endif

public class QuaternionEulerAttribute : PropertyAttribute {
}

/*
 *	(C) 2014 ERAL
 *	Distributed under the Boost Software License, Version 1.0.
 *	(See copy at http://www.boost.org/LICENSE_1_0.txt)
 */

using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;

[CustomPropertyDrawer(typeof(QuaternionEulerAttribute))]
public class QuaternionEulerPropertyDrawer : PropertyDrawer {
	
	/// <summary>
	/// GUI描画
	/// </summary>
	/// <param name="position">描画領域</param>
	/// <param name="property">属性を付与した値</param>
	/// <param name="label">ラベル</param>
	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
		var quaternion_euler_attribute = (QuaternionEulerAttribute)attribute;
		
		if (SerializedPropertyType.Quaternion == property.propertyType) {
			EditorGUIUtility.LookLikeControls();
			var is_update = (!quaternion_euler_attribute.last.Equals(property.quaternionValue));
			is_update = is_update || (Quaternion.Euler(quaternion_euler_attribute.value) != quaternion_euler_attribute.last);
			if (is_update) {
				quaternion_euler_attribute.value = property.quaternionValue.eulerAngles;
				quaternion_euler_attribute.last = Quaternion.Euler(quaternion_euler_attribute.value);
			}
			EditorGUI.BeginChangeCheck();
			quaternion_euler_attribute.value = EditorGUI.Vector3Field(position, label, quaternion_euler_attribute.value);
			if (EditorGUI.EndChangeCheck()) {
				quaternion_euler_attribute.last = property.quaternionValue = Quaternion.Euler(quaternion_euler_attribute.value);
			}
		} else {
			EditorGUI.LabelField(position, label, new GUIContent("This type has not supported."));
		}
	}
}
#endif //UNITY_EDITOR

public class QuaternionEulerAttribute : PropertyAttribute {
	public Vector3		value = Vector3.one; //Quaternion.identityでは無い値
	public Quaternion	last = Quaternion.identity;
}

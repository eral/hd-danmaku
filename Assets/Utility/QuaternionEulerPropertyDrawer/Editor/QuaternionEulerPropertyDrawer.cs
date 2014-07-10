using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(QuaternionEulerAttribute))]
public class QuaternionEulerPropertyDrawer : PropertyDrawer {
	
	/// <summary>
	/// コンストラクタ
	/// </summary>
	public QuaternionEulerPropertyDrawer() {
	}
	
	/// <summary>
	/// GUI描画
	/// </summary>
	/// <param name="position">描画領域</param>
	/// <param name="property">属性を付与した値</param>
	/// <param name="label">ラベル</param>
	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
		QuaternionEulerAttribute quaternion_euler_attribute = (QuaternionEulerAttribute)attribute;
		
		if (SerializedPropertyType.Quaternion == property.propertyType) {
			EditorGUIUtility.LookLikeControls();
			if (quaternion_euler_attribute.last != property.quaternionValue) {
				quaternion_euler_attribute.last = property.quaternionValue;
				quaternion_euler_attribute.value = property.quaternionValue.eulerAngles;
			}
			EditorGUI.BeginChangeCheck();
			quaternion_euler_attribute.value = EditorGUI.Vector3Field(position, label, quaternion_euler_attribute.value);
			if (EditorGUI.EndChangeCheck()) {
				quaternion_euler_attribute.last = property.quaternionValue = Quaternion.Euler(quaternion_euler_attribute.value);
			}
		} else {
			EditorGUI.PropertyField(position, property, label);
		}
	}
}

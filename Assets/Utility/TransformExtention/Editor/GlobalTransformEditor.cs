using UnityEngine;
using UnityEditor;
using System;
using System.Collections.Generic;

/// <summary>
/// 表情用Inspector拡張
/// </summary>
[CustomEditor(typeof(GlobalTransform))]
public sealed class GlobalTransformEditor : Editor
{
	/// <summary>
	/// Inspector描画
	/// </summary>
	public override void OnInspectorGUI()
	{
		GlobalTransform self = (GlobalTransform)target;
		{ //GlobalPosition
			var position_origin = self.transform.position;
			var position = EditorGUILayout.Vector3Field("GlobalPosition", position_origin);
			if (position != position_origin) {
				Undo.RecordObject(self.transform, "Change Global Position");
				self.transform.position = position;
			}
		}
		{ //GlobalRotation
			var rotation_origin = self.transform.rotation.eulerAngles;
			var rotation = EditorGUILayout.Vector3Field("GlobalRotation", rotation_origin);
			if (rotation != rotation_origin) {
				Undo.RecordObject(self.transform, "Change Global Rotation");
				self.transform.rotation = Quaternion.Euler(rotation);
			}
		}
		{ //GlobalScale
			var scale_origin = self.transform.lossyScale;
			var scale = EditorGUILayout.Vector3Field("GlobalScale", scale_origin);
			if (scale != scale_origin) {
				Undo.RecordObject(self.transform, "Change Global Scale");
				if (self.transform.parent) {
					self.transform.localScale = scale - self.transform.parent.lossyScale;
				} else {
					self.transform.localScale = scale;
				}
			}
		}
	}
}

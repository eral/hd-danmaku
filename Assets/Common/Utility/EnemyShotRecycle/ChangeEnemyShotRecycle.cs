using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class ChangeEnemyShotRecycle : MonoBehaviour {
	public string		m_Format = "Recycle: {0}";
	
	private Transform m_EnemyShotTrash = null;
	
	/// <summary>
	/// 初回更新前
	/// </summary>
	void Start () {
		var enemy_shot_trash = GameObject.FindGameObjectWithTag("EnemyShotTrash");
		if (enemy_shot_trash) {
			m_EnemyShotTrash = enemy_shot_trash.transform;
		}
		ApplyActive_(true);
	}
	
	/// <summary>
	/// GUI描画
	/// </summary>
	void OnGUI () {
		var c_scale = new Vector2(Screen.width / 1280.0f, Screen.height / 720.0f);
		var rect = new Rect(16.0f * c_scale.x, (16.0f + 40.0f * 1) * c_scale.y, 200.0f * c_scale.x, 32.0f * c_scale.y);
		var label = new GUIContent(string.Format(m_Format, m_EnemyShotTrash.gameObject.activeSelf));
		if (GUI.Button(rect, label)) {
			ApplyActive_(!m_EnemyShotTrash.gameObject.activeSelf);
		}
	}
	
	/// <summary>
	/// リサイクル状態の反映
	/// </summary>
	/// <param name="is_recycle">リサイクルするか(true:する,false:しない)</param>
	private void ApplyActive_(bool is_recycle) {
		m_EnemyShotTrash.gameObject.SetActive(is_recycle);
	}
}

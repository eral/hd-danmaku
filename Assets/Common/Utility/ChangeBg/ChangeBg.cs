using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class ChangeBg : MonoBehaviour {
	public GameObject[]	m_GameObjectList;
	public string		m_Format = "BgType: {0}";
	
	private int		m_Current = 0;
	
	/// <summary>
	/// 初回更新前
	/// </summary>
	void Start () {
		ApplyActive_(m_Current);
	}
	
	/// <summary>
	/// GUI描画
	/// </summary>
	void OnGUI () {
		var c_scale = new Vector2(Screen.width / 1280.0f, Screen.height / 720.0f);
		var rect = new Rect(16.0f * c_scale.x, (16.0f + 40.0f * 0) * c_scale.y, 200.0f * c_scale.x, 32.0f * c_scale.y);
		var label = ((0 < m_GameObjectList.Length)
						? new GUIContent(string.Format(m_Format, m_GameObjectList[m_Current].name))
						: null
					);
		if (GUI.Button(rect, label)) {
			if (0 < m_GameObjectList.Length) {
				int index = (m_Current + 1) % m_GameObjectList.Length;
				ApplyActive_(index);
			}
		}
	}
	
	/// <summary>
	/// アクティブ状態の反映
	/// </summary>
	/// <param name="index">アクティブにするインデックス</param>
	private void ApplyActive_(int index) {
		for (var i = 0; i < m_GameObjectList.Length; ++i) {
			if (i == index) {
				m_GameObjectList[i].SetActive(true);
			} else {
				m_GameObjectList[i].SetActive(false);
			}
		}
		m_Current = index;
	}
}

using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using UI = UnityEngine.UI;

public class ChangeBg : MonoBehaviour {
	public GameObject[]	m_GameObjectList;
	public string		m_Format = "BgType: {0}";
	public UI.Text		m_LabelObject;
	
	private int		m_Current = 0;
	
	/// <summary>
	/// 初回更新前
	/// </summary>
	void Start () {
		ApplyActive_(m_Current);
	}
	
	/// <summary>
	/// 切り替え
	/// </summary>
	public void Change () {
		if (0 < m_GameObjectList.Length) {
			int index = (m_Current + 1) % m_GameObjectList.Length;
			ApplyActive_(index);
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

		if (m_LabelObject) {
			var label = ((0 < m_GameObjectList.Length)
							? string.Format(m_Format, m_GameObjectList[m_Current].name)
							: null
						);
			m_LabelObject.text = label;
		}
	}
}

using UnityEngine;
using System.Collections.Generic;
using System.Linq;

[RequireComponent(typeof(GUIText))]
public class FpsText : MonoBehaviour {
	public GUIText	m_Target;
	public string	m_Format = "00.00fps";
	public float[]	m_Times;
	public int		m_Current;

	/// <summary>
	/// 初回更新前
	/// </summary>
	void Start () {
		if (!m_Target) {
			m_Target = GetComponent<GUIText>();
		}
		if (0 == m_Times.Length) {
			m_Times = new float[6];
		}
		for (int i = 0, i_max = m_Times.Length; i < i_max; ++i) {
			m_Times[i] = 1.0f;
		}
		m_Current = 0;
	}
	
	/// <summary>
	/// 更新
	/// </summary>
	void Update () {
		m_Times[m_Current++] = Time.deltaTime;
		if (m_Times.Length <= m_Current) {
			m_Current = 0;
		}
		m_Target.text = ((float)m_Times.Length / m_Times.Sum()).ToString(m_Format);
	}
}

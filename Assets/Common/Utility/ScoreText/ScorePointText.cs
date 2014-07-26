using UnityEngine;

[RequireComponent(typeof(GUIText))]
public class ScorePointText : MonoBehaviour {
	public GUIText		m_Target;
	public PlayerScore	m_PlayerScore;
	public string		m_Format = "#########0points";
	
	/// <summary>
	/// 初回更新前
	/// </summary>
	void Start () {
		if (!m_Target) {
			m_Target = GetComponent<GUIText>();
		}
		if (!m_PlayerScore) {
			var player_game_object = GameObject.FindGameObjectWithTag("Player");
			if (player_game_object) {
				m_PlayerScore = player_game_object.GetComponent<PlayerScore>();
				if (m_PlayerScore) {
					enabled = false;
				}
			}
		}
	}
	
	/// <summary>
	/// 更新
	/// </summary>
	void Update () {
		m_Target.text = m_PlayerScore.m_Point.value.ToString(m_Format);
	}
}

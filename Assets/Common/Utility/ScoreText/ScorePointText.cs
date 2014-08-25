using UnityEngine;

[RequireComponent(typeof(UnityEngine.UI.Text))]
public class ScorePointText : MonoBehaviour {
	public UnityEngine.UI.Text	m_Target;
	public PlayerScore			m_PlayerScore;
	public string				m_Format = "{0: #########0}<size=10>points</size>";
	
	/// <summary>
	/// 初回更新前
	/// </summary>
	void Start () {
		if (!m_Target) {
			m_Target = GetComponent<UnityEngine.UI.Text>();
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
		m_Target.text = string.Format(m_Format, m_PlayerScore.m_Point.value);
	}
}

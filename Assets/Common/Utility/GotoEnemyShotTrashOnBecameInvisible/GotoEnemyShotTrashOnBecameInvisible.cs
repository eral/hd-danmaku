using UnityEngine;
using System.Collections;

public class GotoEnemyShotTrashOnBecameInvisible : MonoBehaviour {

	/// <summary>
	/// Raises the became invisible event.
	/// </summary>
	void OnBecameInvisible(){
		var enemy_shot_trash = GameObject.FindGameObjectWithTag("EnemyShotTrash");
		if (enemy_shot_trash) {
			if (this.gameObject.activeSelf) {
				this.gameObject.SetActive(false);
				this.transform.parent = enemy_shot_trash.transform;
			}
		} else {
			Destroy(this.gameObject);
		}
	}
}

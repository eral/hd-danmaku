using UnityEngine;
using System.Collections;

public class DestroyOnBecameInvisible : MonoBehaviour {

	/// <summary>
	/// Raises the became invisible event.
	/// </summary>
	void OnBecameInvisible(){
		Destroy(this.gameObject);
	}
}

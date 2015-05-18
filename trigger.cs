using UnityEngine;
using System.Collections;

public class trigger : MonoBehaviour {
	public bool overlap;
	public string overObj;

	// tutorial on this somewhere?
	void onTriggerEnter2D(Collider2D other) {
		overlap = true;
		overObj = other.name;
		Debug.Log("Collided with " + overObj);
	}
}

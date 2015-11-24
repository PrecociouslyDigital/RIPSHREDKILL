using UnityEngine;
using System.Collections;

public class Portal : MonoBehaviour {
	
	void OnCollisionEnter2D (Collision2D coll) {
		coll.collider.GetComponent<CC2D>().resetJumps();
	}
}

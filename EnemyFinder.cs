using UnityEngine;
using System.Collections;

public class EnemyFinder : MonoBehaviour {
	public AudioSource audio;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.FindWithTag ("Finish") == null) {
			audio.Play ();
			transform.GetComponentInChildren<LoadNextLevel>().startLoading();
			transform.DetachChildren();
			Destroy(gameObject);
		}
	}
}

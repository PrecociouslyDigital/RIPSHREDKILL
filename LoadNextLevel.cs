using UnityEngine;
using System.Collections;

public class LoadNextLevel : MonoBehaviour {
	public string nextLevelName;
	public void startLoading(){
		Invoke ("loadNext", 10);
		Debug.Log ("Loading");
	}
	void loadNext(){
		Application.LoadLevel (nextLevelName);
	}
}
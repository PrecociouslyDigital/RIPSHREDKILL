using UnityEngine;
using System.Collections;

public class CC2D : MonoBehaviour {
	Rigidbody2D controller;
	public float speed;
	public float jumpRate;
	private int jumps = 0;
	public int maxJumps;
	private float lastRotation;
	private float totalSpin;
	public int combo = 1;
	// Use this for initialization
	void Start () {
		controller = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		controller.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, controller.velocity.y);
		if(Input.GetKeyDown("w") && jumps < maxJumps){
			controller.velocity = new Vector2(controller.velocity.x, jumpRate);
			jumps++;
		}
	}
	public void resetJumps(){
		jumps = 0;
		combo = 1;
	}
	public int getCombo(){
		return combo++;
	}
}

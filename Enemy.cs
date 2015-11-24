using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Enemy : MonoBehaviour {
	public float totalHealth;
	private float health;
	public TextMesh damageText;
	public float textTime;
	public Transform healthBar;
	AudioSource audio;
	void Start(){
		health = totalHealth;
		audio = gameObject.GetComponent<AudioSource> ();
	}
	void OnCollisionEnter2D (Collision2D coll) {
		float vel = coll.rigidbody.angularVelocity < 0 ? -coll.rigidbody.angularVelocity : coll.rigidbody.angularVelocity;
		int combo = coll.collider.GetComponent<CC2D>().getCombo();
		health -= vel * combo;
		Debug.Log (healthBar.localScale);
		healthBar.localScale = new Vector3 (health / totalHealth, healthBar.localScale.y, healthBar.localScale.z);
		damageText.text = vel + " x " + combo +" times combo!";
		damageText.fontSize = 14 + combo;
		CancelInvoke ("resetText");
		Invoke ("resetText", textTime);
		Debug.Log (coll.rigidbody.angularVelocity);
		audio.Play ();
		if (health < 0) {
			Destroy (gameObject);
		}
	}
	void resetText(){
		damageText.text = "";
	}
}

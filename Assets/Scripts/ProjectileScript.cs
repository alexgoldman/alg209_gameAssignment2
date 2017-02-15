using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour {

	public Rigidbody2D player;
	public AudioSource hitSound;
	private PlayerController anotherScript;


	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("Alien")) {
			Destroy (other.gameObject);
			Destroy (gameObject);
			hitSound.Play ();


			anotherScript = player.GetComponent < PlayerController > ();
			anotherScript.setScoreText ();
			//obj.setScoreText ();



		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FieldController : MonoBehaviour {

	public AudioSource alienDyingScream;
	public AudioSource loseSound;

	int alienCounter;
	public Text loseText;
	// Use this for initialization
	void Start () {
		alienCounter = 0;
		loseText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("Alien")) {
			alienDyingScream.Play ();
			Destroy (other.gameObject);
			alienCounter++;
		}
		if (alienCounter >= 5) {
			loseText.text = "You lose!";
			loseSound.Play ();
		}
	}
}

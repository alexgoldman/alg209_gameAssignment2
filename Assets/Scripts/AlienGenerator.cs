using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienGenerator : MonoBehaviour {

	public Rigidbody2D alien;
	public int frameDelta;
	private int counter;

	// Use this for initialization
	void Start () {
		counter = 1;
	}
	
	// Update is called once per frame
	void Update () {
		counter++;
		if (counter % frameDelta == 0) {
			//for (int i = 0; i < Random.Range (1, 5); i++) {
				Rigidbody2D alienClone = (Rigidbody2D)Instantiate (alien, transform.position, transform.rotation);
			//}
		}
	}
}

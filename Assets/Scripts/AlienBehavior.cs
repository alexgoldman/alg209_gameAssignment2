using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienBehavior : MonoBehaviour {


	private float speed;
	private float posY;
	private float posX;
	// Use this for initialization
	void Start () {
		speed = 0.05f;
		posY = Random.Range (-4.1f, 2.2f);
		transform.position = new Vector3 (11.5f,posY);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (transform.position.x - speed, posY);
	}
}

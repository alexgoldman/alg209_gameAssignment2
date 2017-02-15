using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {


	public Rigidbody2D projectile;


	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Mouse0)) {

			ProjectileAttack ();
		}
	}

	void ProjectileAttack(){
		Rigidbody2D pPrefab = Instantiate (projectile, transform.position, Quaternion.identity) as Rigidbody2D;
		pPrefab.GetComponent<Rigidbody2D>().AddForce(transform.right * 1000);
	}





}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour {

	public Rigidbody2D player;
	public int speed;
	public AudioSource crashSound;
	private CapsuleCollider2D playerCollider;
	private SpriteRenderer playerSprite;
	private string spriteDirection;
	public Text healthText;
	public int healthCount;
	public Text loseText;
	public Text scoreText;
	public Text winText;
	public int scoreCount;
	public AudioSource loseSound;
	public AudioSource winSound;

	// Use this for initialization
	void Start () {
		player = GetComponent<Rigidbody2D> ();
		playerCollider = GetComponent<CapsuleCollider2D> ();
		playerSprite = GetComponent<SpriteRenderer> ();
		spriteDirection = "right";
		healthCount = 4;
		setHealthText ();
		loseText.text = "";
		scoreCount = -1;
		setScoreText ();
		winText.text = "";
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 move = new Vector3 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"), 0.0f);
		transform.position += move * speed * Time.deltaTime;

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			spriteDirection = "Left";
			playerSprite.flipX = false;

		} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
			spriteDirection = "right";
			playerSprite.flipX = true;


		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("Alien")) {
			crashSound.Play ();
			Destroy (other.gameObject);
			setHealthText ();
		}
	}

	public void setHealthText(){
		
		if (healthCount > 0) {
			healthCount--;
			healthText.text = "Health: " + healthCount.ToString ();

		}
		if (healthCount == 0) {
			loseText.text = "You lose!";
			loseSound.Play ();

		} 
	}

	public void setScoreText(){
		scoreCount++;
		scoreText.text = "Score: " + scoreCount.ToString ();

		if (scoreCount ==10) {
			winText.text = "You win!";
			winSound.Play ();
		}

	}
}

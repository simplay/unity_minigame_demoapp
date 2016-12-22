using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	private Rigidbody rb;

	private int score;
	public Text scoreText;
	public Text winText;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		score = 0;
		DisplayScore ();
		winText.text = "";
	}
	
	// Update is called once per frame: before calling a frame
	void Update () {}

	// FixedUpdate is called before any physics calculations
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movementDirection = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		// apply a directionaly movement to this rigid body
		rb.AddForce (movementDirection * speed);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("CollectableItem")) {
			other.gameObject.SetActive (false);
			score++;
			DisplayScore ();
		}
	}

	void DisplayScore () {
		scoreText.text = "Score " + score.ToString ();
		if (score == 5) {
			winText.text = "You Win!";
		}
	}
}

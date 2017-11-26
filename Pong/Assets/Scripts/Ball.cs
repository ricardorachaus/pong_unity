using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	// Rigidbody of the ball
	public Rigidbody2D rb;

	// Force to be applied in X-Axis
	private float xForce = 200;
	// Force to be applied in Y-Axis
	private float yForce = 50;

	/* Initialize the rigidbody and apply force to the ball */
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		rb.AddForce(transform.right * xForce);
	}

	/* Handle the collision of the ball with another object */
	void OnCollisionEnter2D(Collision2D other) {

		HandleXCollision(other);

		if (other.gameObject.name == "Player1" ||
			other.gameObject.name == "Player2") {
			HandleYCollision(other);
		}

		
	}

	/* Handle the collision in X-Axis */
	private void HandleXCollision(Collision2D other) {
		if (other.transform.position.x < Screen.width / 2) {
			rb.AddForce(transform.right * -xForce);
		}
		else if (other.transform.position.x > Screen.width / 2) {
			rb.AddForce(transform.right * xForce);
		}
	}

	/* Handle the collision in Y-Axis */
	private void HandleYCollision(Collision2D other) {

		if (other.contacts[0].point.y < other.transform.position.y) {
			rb.AddForce(transform.up * -yForce);
		}
		else if (other.contacts[0].point.y == other.transform.position.y) {
			rb.AddForce(Vector2.zero);
		}
		else {
			rb.AddForce(transform.up * yForce);
		}
	}
}

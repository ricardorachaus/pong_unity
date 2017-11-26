using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {

	// Paddle that represents player 1
	public GameObject player1;
	// Paddle that represents player 1
	public GameObject player2;

	// Touch on the screen
	private Touch touch;
	// Last position of the paddle 
	private Vector2 lastPosition;
	// The position of the start touch
	private Vector2 startTouchPosition;
	
	/* Call the HandleInput every time */
	void Update () {
		HandleInput();
	}

	/* Handle the user input based on the touch */
	void HandleInput() {
		if (Input.touchCount > 0) {
			touch = Input.GetTouch(0);

			if (touch.position.x > Screen.width / 2) {
				MovePlayer(player2);
			}
			else {
				MovePlayer(player1);
			}
		}
	}

	/* Move the respective player according to the type of touch */
	private void MovePlayer(GameObject player) {
		switch (touch.phase) {
			case TouchPhase.Began:
			TouchesBegan();
			break;

			case TouchPhase.Moved:
			TouchesMoved(player);
			break;

			default:
				break;
		}
	}

	/* When type of touch is Began, calls this method */
	private void TouchesBegan() {
		startTouchPosition = touch.position;
	}

	/* When type of touch is Moved, calls this method */
	private void TouchesMoved(GameObject player) {
		var delta = (touch.position - startTouchPosition) / 1000;
		var position = player.transform.position;

		lastPosition = position;
		position.y += delta.y;

		if (position.y > -4.2 && position.y < 4.2) {
			player.transform.position = position;
		}
		else {
			player.transform.position = lastPosition;
		}

	}
}

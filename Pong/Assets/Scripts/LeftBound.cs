using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftBound : MonoBehaviour {

	/* Add score to the right player */
	void OnCollisionEnter2D(Collision2D other) {
		GameManager.shared.AddRightScore();
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightBound : MonoBehaviour {

	/* Add score to the left player */
	void OnCollisionEnter2D(Collision2D other) {
		GameManager.shared.AddLeftScore();
	}
	
}

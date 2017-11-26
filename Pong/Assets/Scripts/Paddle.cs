using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	/* Play the sound of hitting the paddle */
	void OnCollisionEnter2D(Collision2D other) {
		AudioManager.shared.PlayHitPaddle();	
	}

}

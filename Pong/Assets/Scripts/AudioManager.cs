using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

	// Instance of the AudioManager
	public static AudioManager shared;

	// Audio clip when hit the wall
	public AudioClip hitWall;
	// Audio clip when hit the paddle
	public AudioClip hitPaddle;

	// Audio source that plays the clip
	private AudioSource source;

	/* Initialize singleton */
	void Start () {
		if (shared == null) {
			shared = this;
		}
		else if (shared != this) {
			Destroy(gameObject);
		}
		DontDestroyOnLoad(gameObject);

		source = GetComponent<AudioSource>();
	}
	
	/* Play the sound of hitting the wall */
	public void PlayHitWall() {
		source.PlayOneShot(hitWall);
	}

	/* Play the sound of hitting the paddle */
	public void PlayHitPaddle() {
		source.PlayOneShot(hitPaddle);
	}
}

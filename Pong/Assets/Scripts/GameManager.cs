using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	// Instance of the GameManager
	public static GameManager shared;

	// Reference to the ball
	public GameObject ball;

	// Score of the left player
	private int leftScore = 0;
	// Score of the right player
	private int rightScore = 0;
	// Text of the left player score
	[SerializeField] private Text leftScoreText;
	// Text of the right player score
	[SerializeField] private Text rightScoreText;

	// Initialize singleton
	void Start () {
		if (shared == null) {
			shared = this;
		}
		else if (shared != this) {
			Destroy(gameObject);
		}
		DontDestroyOnLoad(gameObject);
	}

	/* Add and update the left score */
	public void AddLeftScore() {
		leftScore += 1;
		leftScoreText.text = leftScore.ToString();
		ResetBallPosition();
		AudioManager.shared.PlayHitWall();
	}

	/* Add and update the right score */
	public void AddRightScore() {
		rightScore += 1;
		rightScoreText.text = rightScore.ToString();
		ResetBallPosition();
		AudioManager.shared.PlayHitWall();
	}

	/* Reset ball position after a score */
	private void ResetBallPosition() {
		var position = ball.transform.position;
		position = Vector2.zero;
		ball.transform.position = position;
	}
}

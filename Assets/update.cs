using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class update : MonoBehaviour {
	[SerializeField]
	public Text ScoreText;
	static int Score = 0;



	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Player") {
			Destroy(gameObject);

			Score++;
			ScoreText.text = "Score:" + Score;
		}

	}
}
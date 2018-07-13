using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class changeScenes : MonoBehaviour {

	ScoreManager score;
	private int currentScore;
	public int scoreLimit;
	public string nextLevel;

	// Use this for initialization
	void Start () {

		score = FindObjectOfType<ScoreManager> ();
	}

	// Update is called once per frame
	void Update () {

		currentScore = score.getScore();
	}

	void OnTriggerEnter2D (Collider2D other) {

		if (other.gameObject.name == "Player"){
			if (currentScore == scoreLimit){
				SceneManager.LoadScene (nextLevel);

			}
		}
	}
}

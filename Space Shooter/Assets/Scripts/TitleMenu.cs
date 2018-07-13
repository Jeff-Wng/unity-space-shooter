using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour {

	public string startLevel;
	public string settings;

	public void newGame() {

		SceneManager.LoadScene ("Level1");
		PlayerPrefs.SetInt ("CurrentScore", 0);
		PlayerPrefs.SetInt ("CurrentHealth", 5);
	}

	public void Directions () {
		SceneManager.LoadScene ("Directions");
	}

	public void HighScores () {

		SceneManager.LoadScene ("HighScore");
	}

	public void Settings () {

		SceneManager.LoadScene ("Settings");
	}

	public void Quit () {

		Application.Quit ();
	}
}

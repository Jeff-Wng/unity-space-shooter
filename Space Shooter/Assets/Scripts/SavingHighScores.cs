using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SavingHighScores : MonoBehaviour {
	const int NUM_SCORES = 5;

	// Use this for initialization
	void Start () {

		//int[] highScores = new int[NUM_SCORES];
		int Score = GameControl.Instance.getScore ();
		string Name = GameControl.Instance.getName ();

		string scoreKey = "HighScore";
		string nameKey = "HighScoreName";

		for (int i = 0; i < NUM_SCORES; i++) {
			string curNameKey = (nameKey + i).ToString();
			string curScoreKey = (scoreKey + i).ToString();

			if (!(PlayerPrefs.HasKey (curScoreKey))) {
				print ("no such score");
				PlayerPrefs.SetInt (curScoreKey, Score);
				PlayerPrefs.SetString (curNameKey, Name);
			} 

			else {
				int score = PlayerPrefs.GetInt (curScoreKey);


				if (Score > score) {
					int tempScore = score;
					string tempName = PlayerPrefs.GetString (curNameKey);

					PlayerPrefs.SetInt (curScoreKey, Score);
					PlayerPrefs.SetString (curNameKey, Name);

					Name = tempName;
					Score = tempScore;
				}
			}
		}		
		//string nameKey = "HighScoreName";
		//string scoreKey = "HighScore";

		for (int i = 0; i < NUM_SCORES; i++)
		{
			print (PlayerPrefs.GetString ("HighScoreName"+i) + " " + PlayerPrefs.GetInt ("HighScore" + i));
		}

		Application.Quit ();
	}
}
using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {
	public string playerName;
	public int score;

	public static GameControl Instance;

	// Use this for initialization
	void Start () {
		playerName = "";
		score = PlayerPrefs.GetInt ("CurrentScore");
	}

	void Awake()
	{
		if (Instance == null) {
			DontDestroyOnLoad (gameObject);
			Instance = this;
		} else {
			Destroy (gameObject);
		}
	}

	public void setScore(int s)
	{
		score = s;
	}

	public int getScore()
	{
		return score;
	}

	public void increaseScore (int a)
	{
		score += a;
	}

	public void setName (string n)
	{
		playerName = n;
	}

	public string getName()
	{
		return playerName;
	}


}

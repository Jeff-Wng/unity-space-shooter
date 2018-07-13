using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour {
	public InputField input;

	// Use this for initialization
	void Start () {
		if (input == null) {
			input = GetComponent<InputField> ();
		}

	}

	// Update is called once per frame
	void Update () {

	}

	public void StartGame()
	{
		string n = input.text;
		print (n);
		GameControl.Instance.setName (n);
		SceneManager.LoadScene ("SavingHighScore");
	}
}

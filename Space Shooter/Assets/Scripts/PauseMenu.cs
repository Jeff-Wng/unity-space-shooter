using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	string resume;
	string quit;
	string directions;

	public bool isPaused;

	public GameObject pauseMenu;

	void Update() {

		if (isPaused) {
			pauseMenu.SetActive (true);
			Time.timeScale = 0f;	//Game is stop when pause menu is up
		} else {
			pauseMenu.SetActive (false);
			Time.timeScale = 1f;	//Game will resume when pause menu is down
		}

		//If ESC is pressed, pause menu will pop up
		if (Input.GetKeyDown (KeyCode.Escape)) {

			isPaused = !isPaused;
		}

	}

	public void Resume() {

		isPaused = false;
	}


	//Returns player back to the title screen
	public void Quit() {

		SceneManager.LoadScene ("Title Menu");
	}

}
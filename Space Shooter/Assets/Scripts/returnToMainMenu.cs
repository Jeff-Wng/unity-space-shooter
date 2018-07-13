using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class returnToMainMenu : MonoBehaviour {

	public void mainMenu () {
		SceneManager.LoadScene ("Title Menu");
	}
}

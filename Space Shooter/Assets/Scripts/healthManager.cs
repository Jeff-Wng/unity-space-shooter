using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class healthManager : MonoBehaviour {

	public static int health;

	Text text;

	// Use this for initialization
	void Start () {

		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		text.text = "" + playerCollision.getHealth ();
	}

	public void loseHealth(int health_lose) {

		health -= health_lose;
		PlayerPrefs.SetInt ("CurrentHealth", health);
	}

	public int getHealth() {

		return health;
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour {

	public int startingLives;
	private int lifeCounter;

	private Text text;

	// Use this for initialization
	void Start () {

		text = GetComponent<Text>();

		lifeCounter = startingLives;
	}
	
	// Update is called once per frame
	void Update () {

		text.text = "x " + lifeCounter;
	}

	public void takeLife() {

		lifeCounter--;
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public GameObject currentCheckpoint;

	private playerController player;



	// Use this for initialization
	void Start () {
		player = FindObjectOfType<playerController> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

}

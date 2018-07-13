using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {


	public float speed = 15.0f;
	float shipBoundary = 1.1f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		//Player movement
		Vector3 pos = transform.position;

		pos.x += Input.GetAxis ("Horizontal") * speed * Time.deltaTime;

		transform.position = pos;

		//Player boundaries
		//Handles the width boundaires 
		float screenRatio = (float)Screen.width / (float)Screen.height;
		float screenWidth = Camera.main.orthographicSize * screenRatio;

		if (pos.x + shipBoundary > screenWidth) {
			pos.x = screenWidth - shipBoundary;
		}

		if (pos.x - shipBoundary < -screenWidth) {
			pos.x = -screenWidth + shipBoundary;
		}

		transform.position = pos;


	}
}

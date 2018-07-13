using UnityEngine;
using System.Collections;

public class bulletFoward : MonoBehaviour {

	float speed = 10f;

	// Update is called once per frame
	void Update () {
	
		Vector3 pos = transform.position;

		Vector3 velocity = new Vector3 (0, speed * Time.deltaTime, 0);

		pos += velocity;

		transform.position = pos;
	}
}

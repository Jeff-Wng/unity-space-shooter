using UnityEngine;
using System.Collections;

public class facesPlayer : MonoBehaviour {

	Transform player;
	float maxRot = 180;
	
	// Update is called once per frame
	void Update () {
		if (player == null) {

			GameObject go = GameObject.Find ("Player");

			if (go != null)
				player = go.transform;
		}

		if (player == null)
			return;

		Vector3 direction = player.position - transform.position;
		direction.Normalize ();

		float zAngle = Mathf.Atan2 (direction.y, direction.x) * Mathf.Rad2Deg - 90;

		Quaternion enemy_rotation = Quaternion.Euler (0, 0, zAngle);

		transform.rotation = Quaternion.RotateTowards (transform.rotation, enemy_rotation, maxRot * Time.deltaTime);

	}
}

using UnityEngine;
using System.Collections;

public class playerShoot : MonoBehaviour {

	public GameObject bulletPrefab;
	public GameObject bulletPosition0;
	public GameObject bulletPosition1;

	// Update is called once per frame
	void Update () {

		//Fires bullets when spacebar is pressed
		if (Input.GetKeyDown ("space")) {

			//Instantiate the first bullet
			GameObject bullet0 = (GameObject)Instantiate (bulletPrefab);
			bullet0.transform.position = bulletPosition0.transform.position;

			//Instantiate second bullet
			GameObject bullet1 = (GameObject)Instantiate (bulletPrefab);
			bullet1.transform.position = bulletPosition1.transform.position;
		}
	}

}

using UnityEngine;
using System.Collections;

public class enemyShooting : MonoBehaviour {
	
	public GameObject bulletPrefab;
	public GameObject bulletPosition0;
	public GameObject bulletPosition1;

	public float shootDelay = 2f;
	float coolDownTimer = 0;

	// Update is called once per frame
	void Update () {

		coolDownTimer -= Time.deltaTime;

		if (coolDownTimer <= 0){

			coolDownTimer = shootDelay;

			//Instantiate the first bullet
			GameObject bullet0 = (GameObject)Instantiate (bulletPrefab);
			bullet0.transform.position = bulletPosition0.transform.position;

			//Instantiate second bullet
			GameObject bullet1 = (GameObject)Instantiate (bulletPrefab);
			bullet1.transform.position = bulletPosition1.transform.position;
	}
}	
}
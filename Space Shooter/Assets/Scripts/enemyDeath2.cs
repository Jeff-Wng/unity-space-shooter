using UnityEngine;
using System.Collections;

public class enemyDeath2 : MonoBehaviour {

	public float health = 1f;

	AI enemy;

	public GameObject deathParticle;
	public GameObject hitParticle;

	int pointsToAdd = 100;

	void Start () {

		enemy = FindObjectOfType<AI> ();
	}

	void Update(){

		if (health <= 0f) {
			
			ScoreManager.Addpoints (pointsToAdd);
			Destroy (gameObject);
			Instantiate (deathParticle, enemy.transform.position, enemy.transform.rotation);

		}
	
	}

	void OnTriggerEnter2D(Collider2D other){
			
		health--;
		Instantiate (hitParticle, enemy.transform.position, enemy.transform.rotation);

	}
}

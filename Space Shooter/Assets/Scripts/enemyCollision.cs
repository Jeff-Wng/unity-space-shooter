using UnityEngine;
using System.Collections;

public class enemyCollision : MonoBehaviour {

	int health = 1;

	void Start() {

	}

	void OnTriggerEnter2D(){
		health--;
	}

	void Update(){

		if (health <= 0)
			Die ();

	}
	void Die(){
		Destroy (gameObject);
	}
}

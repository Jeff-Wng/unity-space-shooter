using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class playerCollision : MonoBehaviour {

	static int health;

	private healthManager h_manager;
	private playerController player;

	public GameObject deathParticle;
	public GameObject hitParticle;

	void Start () {

		player = FindObjectOfType<playerController> ();
		health = PlayerPrefs.GetInt ("CurrentHealth");
		h_manager = FindObjectOfType<healthManager> ();
	}

	void OnTriggerEnter2D (Collider2D other){
		
		if (other.gameObject.tag == "Enemy") {
			health--;
			Instantiate (hitParticle, player.transform.position, player.transform.rotation);
	
			PlayerPrefs.SetInt ("CurrentHealth", health);

		}
	}

	void Update(){

		if (health <= 0) {
			Die ();
		}
	}

	void Die(){

		Instantiate (deathParticle, player.transform.position, player.transform.rotation);
		Destroy (gameObject);
		SceneManager.LoadScene ("GameOver");
	}

	public static int getHealth() {
		return health;
	}
}

using UnityEngine;
using System.Collections;

public class justInTime : MonoBehaviour {

	public GameObject text;

	void Start () {

		text = GameObject.Find ("Directions");
		Destroy (text, 2);
	}
}
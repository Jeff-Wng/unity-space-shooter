using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {

	public float speed = 10f;
	public bool moveRight;

	public Transform wallCheck;
	public float wallCheckRadius;
	public LayerMask whatIsWall;
	private bool hittingWall;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update ()
	{

		hittingWall = Physics2D.OverlapCircle (wallCheck.position, wallCheckRadius, whatIsWall);

		if (hittingWall)
			moveRight = !moveRight; 	//When wall is hit, move in opposite direction

		if (moveRight) {

			transform.localScale = new Vector3 (-0.35f, 0.35f, 0.35f);
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed, GetComponent<Rigidbody2D> ().velocity.y);

		} else {

			transform.localScale = new Vector3 (0.35f, 0.35f, 0.35f);
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-speed, GetComponent<Rigidbody2D> ().velocity.y);

		}
	}
}

using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	public float moveSpeed;
	private Vector2 move;

	// Use this for initialization
	void Start () {
		moveSpeed = 5.0f;
		move = new Vector2 (0.0f, 0.0f);
	}

	void FixedUpdate () {

		move.x = 0.0f;
		move.y = 0.0f;

		if(Input.GetKey(KeyCode.D)) {
			move.x += moveSpeed;
		}
		
		if(Input.GetKey(KeyCode.A)) {
			move.x += -moveSpeed;
		}
		
		if(Input.GetKey(KeyCode.W)) {
			move.y += moveSpeed;
		}
		
		if(Input.GetKey(KeyCode.S)) {
			move.y += -moveSpeed;
		}

		rigidbody2D.velocity = move;

	}
	
	// Update is called once per frame
	void Update () {

	}
}

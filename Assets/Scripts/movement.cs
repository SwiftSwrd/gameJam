using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	public bool selected;
	public GameObject current;


	public float moveSpeed;
	private Vector2 move;

	// Use this for initialization
	void Start () {
		if (gameObject.CompareTag ("player")) {
			selected = true;
		}

		moveSpeed = 5.0f;
		move = new Vector2 (0.0f, 0.0f);
	}

	bool collide = false;

	void OnCollisionStay2D(Collision2D coll) {
		Debug.Log ("Collision detected");
		//collide = true;
	}
	bool sync = false;

	void OnMouseDown() {
		selected = true;
		sync = true;
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

		if(selected){
			rigidbody2D.velocity = move;
		} else if (collide) {
			rigidbody2D.velocity = -move;
			collide = false;
		} else {
			rigidbody2D.velocity = new Vector2(0.0f,0.0f);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0) && !sync){
			//Debug.Log ("offclick");
			selected = false;
		}
		sync = false;
	}
}

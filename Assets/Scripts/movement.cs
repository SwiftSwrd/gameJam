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

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("Collision detected");
	}

	void OnColliderEnter2D(Collision other) {
		Debug.Log ("Collision detected");
	}

	void OnMouseUp() {
		//selected = false;
		Debug.Log ("1");
	}

	void OnMouseUpAsButton() {
		//selected = true;
		Debug.Log ("2");
	}

	void OnMouseDown() {
		//selected = true;
		Debug.Log ("3");
	}



	void FixedUpdate () {
		if(selected){
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
	}
	
	// Update is called once per frame
	void Update () {
	}
}

using UnityEngine;
using System.Collections;

public class telekinesis : MonoBehaviour {

	/*private float dist;
	private Transform toDrag;
	private bool dragging = false;
	private Vector3 offset;*/

	private bool dragOkay = true;

	private Vector3 prev;


	// Use this for initialization
	void Start () {
	
	}

	void OnMouseDrag() {
		if(dragOkay){
			//transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0.0f);
			Vector3 v3 = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0.0f) - transform.position;
			transform.Translate(v3);
			prev = transform.position;
			//Debug.Log (Input.mousePosition);
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("Collision detected");
		if(other.gameObject.CompareTag("stop")){
			dragOkay = false;
			Debug.Log ("dragOkay = false");
			transform.position = prev;
		}
	}

	void OnColliderEnter2D(Collision other) {
		Debug.Log ("Collision detected");
	}

	// Update is called once per frame
	void Update () {



		if (Input.GetMouseButtonUp (0)) {
			dragOkay = true;
		}

	}
}
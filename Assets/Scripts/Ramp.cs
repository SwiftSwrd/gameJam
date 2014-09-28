using UnityEngine;
using System.Collections;

public class Ramp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnter2d(Collision2D coll){
		Debug.Log ("If this doesn't show big problems");
		if(coll.gameObject.CompareTag("High")){
			Debug.Log("Minor Success");
		}
	}


	// Update is called once per frame
	void Update () {
	
	}
}

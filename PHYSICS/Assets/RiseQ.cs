using UnityEngine;
using System.Collections;

public class RiseQ : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey (KeyCode.Q) == true) {

			gameObject.GetComponent<Rigidbody>().AddForce (new Vector3 (0, 250, 0));

		}
	}
}

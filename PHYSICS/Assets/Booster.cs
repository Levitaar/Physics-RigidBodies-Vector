using UnityEngine;
using System.Collections;

public class Booster : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Rigidbody rb = gameObject.GetComponent<Rigidbody>();

		rb.AddTorque (new Vector3 (250, 0, 0));
	}
}

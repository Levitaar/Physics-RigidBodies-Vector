﻿using UnityEngine;
using System.Collections;

public class RiseR : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey (KeyCode.R) == true) {
			
			gameObject.GetComponent<Rigidbody>().AddForce (new Vector3 (0, 50, 0));
			
		}
	}
}
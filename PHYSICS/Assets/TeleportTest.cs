using UnityEngine;
using System.Collections;

public class TeleportTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log (gameObject.transform.position);

	}
	
	// Update is called once per frame
	void Update () {
	
		gameObject.transform.position = 
			gameObject.transform.position + new Vector3(0.01f, 0, 0);
	}
}

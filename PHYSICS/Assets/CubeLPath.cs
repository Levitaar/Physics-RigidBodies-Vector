using UnityEngine;
using System.Collections;

public class CubeLPath : MonoBehaviour {

	private float YSpeed = .1f;
	
	// Use this for initialization
	void Start () {
		Debug.Log (gameObject.transform.position);

	}
	
	// Update is called once per frame
	void Update () {
	
		gameObject.transform.position =
			gameObject.transform.position + new Vector3(0, YSpeed, 0);


		if (gameObject.transform.position.y > 10) {
			YSpeed = -YSpeed;

		}

		if (gameObject.transform.position.y < 0) {
			YSpeed = -YSpeed;
			
		}


	}

}

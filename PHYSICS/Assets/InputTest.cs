using UnityEngine;
using System.Collections;

public class InputTest : MonoBehaviour {

	public float PowerForce;
	public int TorqueZ;

	private GameObject hammer;

	// Use this for initialization
	void Start () {
	
		TorqueZ = 30;
		PowerForce = 35;
		hammer = GameObject.Find ("hammer");
	}
	
	// Update is called once per frame
	void Update () {
		Rigidbody rb = gameObject.GetComponent<Rigidbody>();

		//If "Spacebar" is pressed, move object
		if (Input.GetKey (KeyCode.Space) == true) {

			rb.AddForce (new Vector3 (PowerForce, 0, 0));
			rb.AddTorque (new Vector3 (150, TorqueZ, 0));
	}
		if (Input.GetKey (KeyCode.Q) == true) {
			hammer.transform.localScale = new Vector3( 3, 4, 5);
			Debug.Log( "Q was pressed" );
	}
		rb.AddForce( new Vector3(20, 0, 0) * Input.GetAxis("Horizontal"));
	}

}
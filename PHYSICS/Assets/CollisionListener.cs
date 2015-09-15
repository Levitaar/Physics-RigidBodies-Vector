using UnityEngine;
using System.Collections;

public class CollisionListener : MonoBehaviour {

	void OnTriggerEnter( Collider otherObject ) {}

	void OnCollisionEnter( Collision thiscollision ) {

		if (thiscollision.gameObject.name == "Wall") {
			print("Physics Collision");
	}
	}
}
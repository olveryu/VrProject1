using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Darts : MonoBehaviour {
	
	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "dartBoard") {
			gameObject.GetComponent<Rigidbody> ().isKinematic = true;
			gameObject.GetComponent<Rigidbody> ().useGravity = false;
		}
	}
}

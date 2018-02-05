using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Darts : MonoBehaviour {
	public GameController ggc ; 
	public Vector3 position;

	public float angle; 
	public Transform target;
	public Vector3 refVector;

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "dartBoard") {
			gameObject.GetComponent<Rigidbody> ().isKinematic = true;
			gameObject.GetComponent<Rigidbody> ().useGravity = false;
			ggc.scoreUpdate (5);
		}
		if (col.gameObject.tag == "dartBoard") {
			//Debug.Log ("Dart update"); 
			//Vector3 temp = target.localPosition;
			//temp.Set (1, 0, 0);
			//refVector = (temp - Vector3.zero);
			//Debug.DrawLine (target.localPosition, temp, Color.magenta);
			position = col.contacts[0].point;
			//Debug.Log ("initial position" + position);
			position = target.position - position;
			//position = target.localPosition - transform.localPosition;
			Debug.Log ("target position" + target.position);
			Debug.Log ("contact position" + position);			
			//Debug.Log ("transform local position" + transform.localPosition);
			//Debug.Log ("vector" + position);
			angle = Vector3.Angle (position, transform.forward);
			Debug.Log ("angle" + angle);
			ggc.degreeUpdate (angle);
		}
		//if(angle>0&&angle<

		}
	}
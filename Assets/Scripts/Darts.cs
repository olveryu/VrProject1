using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Darts : MonoBehaviour {
	public GameController ggc ; 
	public Vector3 position;
	public float angle; 
	public Transform target;
	public Vector3 refVector;
	public float dis_from_Ctr;
	public DartBoard Db;

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "dartBoard") {
			Db.soundUpdate();
			gameObject.GetComponent<Rigidbody> ().isKinematic = true;
			gameObject.GetComponent<Rigidbody> ().useGravity = false;
			//ggc.scoreUpdate (5);
		}
		if (col.gameObject.tag == "dartBoard") {
			//Debug.Log ("Dart update"); 
			//Vector3 temp = target.localPosition;
			//temp.Set (1, 0, 0);
			//refVector = (temp - Vector3.zero);
			//Debug.DrawLine (target.localPosition, temp, Color.magenta);
			position = col.contacts [0].point;
			//Debug.Log ("initial position" + position);
			position = target.position - position;
			dis_from_Ctr = position.magnitude;
			//position = target.localPosition - transform.localPosition;
			Debug.Log ("target position" + target.position);
			Debug.Log ("contact position" + position);			
			//Debug.Log ("transform local position" + transform.localPosition);
			//Debug.Log ("vector" + position);
			angle = Vector3.Angle (position, transform.forward);
			Debug.Log ("angle" + angle);
			ggc.degreeUpdate (angle);
			// This is giving the X, Y, and Z corrdinates to the debug system. 
			Debug.Log("Distance From Center " + dis_from_Ctr);

			// If Statments for the top part of the bored. 
			//the upper part of the board is actually in the negitive y direction, i dont know why that is but whatever. 
			if (dis_from_Ctr > 3.9) {
				ggc.scoreUpdate (0);
			} else if (dis_from_Ctr < .25) {
				ggc.scoreUpdate (50);
			} else if (dis_from_Ctr >= .25 && dis_from_Ctr < .30) {
				ggc.scoreUpdate (25);
			}
			else if (angle >= 0 && angle < 10 && position.y < 0) {
				if (dis_from_Ctr <= 2.5 && dis_from_Ctr >= 2.3) {
					ggc.scoreUpdate (6 * 3);
				} else if (dis_from_Ctr <= 3.9 && dis_from_Ctr >= 3.7) {
					ggc.scoreUpdate (6 * 2);
				} else {
					ggc.scoreUpdate (6);
				}
			} else if (angle >= 10 && angle < 28 && position.y < 0) {
				if (dis_from_Ctr <= 2.5 && dis_from_Ctr >= 2.3) {
					ggc.scoreUpdate (13 * 3);
				} else if (dis_from_Ctr <= 3.9 && dis_from_Ctr >= 3.7) {
					ggc.scoreUpdate (13 * 2);
				} else {
					ggc.scoreUpdate (13);
				}
			} else if (angle >= 28 && angle < 46 && position.y < 0) {
				if (dis_from_Ctr <= 2.5 && dis_from_Ctr >= 2.3) {
					ggc.scoreUpdate (4 * 3);
				} else if (dis_from_Ctr <= 3.9 && dis_from_Ctr >= 3.7) {
					ggc.scoreUpdate (4 * 2);
				} else {
					ggc.scoreUpdate (4);
				}
			} else if (angle >= 36 && angle < 64 && position.y < 0) {
				if (dis_from_Ctr <= 2.5 && dis_from_Ctr >= 2.3) {
					ggc.scoreUpdate (18 * 3);
				} else if (dis_from_Ctr <= 3.9 && dis_from_Ctr >= 3.7) {
					ggc.scoreUpdate (18 * 2);
				} else {
					ggc.scoreUpdate (18);
				}
			} else if (angle >= 64 && angle < 82 && position.y < 0) {
				if (dis_from_Ctr <= 2.5 && dis_from_Ctr >= 2.3) {
					ggc.scoreUpdate (1 * 3);
				} else if (dis_from_Ctr <= 3.9 && dis_from_Ctr >= 3.7) {
					ggc.scoreUpdate (1 * 2);
				} else {
					ggc.scoreUpdate (1);
				}
			} else if (angle >= 82 && angle < 100 && position.y < 0) {
				if (dis_from_Ctr <= 2.5 && dis_from_Ctr >= 2.3) {
					ggc.scoreUpdate (20 * 3);
				} else if (dis_from_Ctr <= 3.9 && dis_from_Ctr >= 3.7) {
					ggc.scoreUpdate (20 * 2);
				} else {
					ggc.scoreUpdate (20);
				}
			} else if (angle >= 100 && angle < 118 && position.y < 0) {
				if (dis_from_Ctr <= 2.5 && dis_from_Ctr >= 2.3) {
					ggc.scoreUpdate (5 * 3);
				} else if (dis_from_Ctr <= 3.9 && dis_from_Ctr >= 3.7) {
					ggc.scoreUpdate (5 * 2);
				} else {
					ggc.scoreUpdate (5);
				}
			} else if (angle >= 118 && angle < 136 && position.y < 0) {
				if (dis_from_Ctr <= 2.5 && dis_from_Ctr >= 2.3) {
					ggc.scoreUpdate (12 * 3);
				} else if (dis_from_Ctr <= 3.9 && dis_from_Ctr >= 3.7) {
					ggc.scoreUpdate (12 * 2);
				} else {
					ggc.scoreUpdate (12);
				}
			} else if (angle >= 136 && angle < 154 && position.y < 0) {
				if (dis_from_Ctr <= 2.5 && dis_from_Ctr >= 2.3) {
					ggc.scoreUpdate (9 * 3);
				} else if (dis_from_Ctr <= 3.9 && dis_from_Ctr >= 3.7) {
					ggc.scoreUpdate (9 * 2);
				} else {
					ggc.scoreUpdate (9);
				}
			} else if (angle >= 154 && angle < 172 && position.y < 0) {
				if (dis_from_Ctr <= 2.5 && dis_from_Ctr >= 2.3) {
					ggc.scoreUpdate (14 * 3);
				} else if (dis_from_Ctr <= 3.9 && dis_from_Ctr >= 3.7) {
					ggc.scoreUpdate (14 * 2);
				} else {
					ggc.scoreUpdate (14);
				}
			} else if (angle >= 172 && angle <= 180 && position.y < 0) {
				if (dis_from_Ctr <= 2.5 && dis_from_Ctr >= 2.3) {
					ggc.scoreUpdate (11 * 3);
				} else if (dis_from_Ctr <= 3.9 && dis_from_Ctr >= 3.7) {
					ggc.scoreUpdate (11 * 2);
				} else {
					ggc.scoreUpdate (11);
				}
			}
			//This is the bottom half of the dart board.
			//This will trigger on the positive y direction, again idk why that is.
			  else if (angle >= 0 && angle < 8 && position.y > 0) {
				if (dis_from_Ctr <= 2.5 && dis_from_Ctr >= 2.3) {
					ggc.scoreUpdate (6 * 3);
				} else if (dis_from_Ctr <= 3.9 && dis_from_Ctr >= 3.7) {
					ggc.scoreUpdate (6 * 2);
				} else {
					ggc.scoreUpdate (6);
				}
			} else if (angle >= 8 && angle < 26 && position.y > 0) {
				if (dis_from_Ctr <= 2.5 && dis_from_Ctr >= 2.3) {
					ggc.scoreUpdate (10 * 3);
				} else if (dis_from_Ctr <= 3.9 && dis_from_Ctr >= 3.7) {
					ggc.scoreUpdate (10 * 2);
				} else {
					ggc.scoreUpdate (10);
				}
			} else if (angle >= 28 && angle < 44 && position.y > 0) {
				if (dis_from_Ctr <= 2.5 && dis_from_Ctr >= 2.3) {
					ggc.scoreUpdate (15 * 3);
				} else if (dis_from_Ctr <= 3.9 && dis_from_Ctr >= 3.7) {
					ggc.scoreUpdate (15 * 2);
				} else {
					ggc.scoreUpdate (15);
				}
			} else if (angle >= 36 && angle < 62 && position.y > 0) {
				if (dis_from_Ctr <= 2.5 && dis_from_Ctr >= 2.3) {
					ggc.scoreUpdate (2 * 3);
				} else if (dis_from_Ctr <= 3.9 && dis_from_Ctr >= 3.7) {
					ggc.scoreUpdate (2 * 2);
				} else {
					ggc.scoreUpdate (2);
				}
			} else if (angle >= 64 && angle < 80 && position.y > 0) {
				if (dis_from_Ctr <= 2.5 && dis_from_Ctr >= 2.3) {
					ggc.scoreUpdate (17 * 3);
				} else if (dis_from_Ctr <= 3.9 && dis_from_Ctr >= 3.7) {
					ggc.scoreUpdate (17 * 2);
				} else {
					ggc.scoreUpdate (17);
				}
			} else if (angle >= 82 && angle < 98 && position.y > 0) {
				if (dis_from_Ctr <= 2.5 && dis_from_Ctr >= 2.3) {
					ggc.scoreUpdate (3 * 3);
				} else if (dis_from_Ctr <= 3.9 && dis_from_Ctr >= 3.7) {
					ggc.scoreUpdate (3 * 2);
				} else {
					ggc.scoreUpdate (3);
				}
			} else if (angle >= 100 && angle < 116 && position.y > 0) {
				if (dis_from_Ctr <= 2.5 && dis_from_Ctr >= 2.3) {
					ggc.scoreUpdate (19 * 3);
				} else if (dis_from_Ctr <= 3.9 && dis_from_Ctr >= 3.7) {
					ggc.scoreUpdate (19 * 2);
				} else {
					ggc.scoreUpdate (19);
				}
			} else if (angle >= 118 && angle < 134 && position.y > 0) {
				if (dis_from_Ctr <= 2.5 && dis_from_Ctr >= 2.3) {
					ggc.scoreUpdate (7 * 3);
				} else if (dis_from_Ctr <= 3.9 && dis_from_Ctr >= 3.7) {
					ggc.scoreUpdate (7 * 2);
				} else {
					ggc.scoreUpdate (7);
				}
			} else if (angle >= 136 && angle < 152 && position.y > 0) {
				if (dis_from_Ctr <= 2.5 && dis_from_Ctr >= 2.3) {
					ggc.scoreUpdate (16 * 3);
				} else if (dis_from_Ctr <= 3.9 && dis_from_Ctr >= 3.7) {
					ggc.scoreUpdate (16 * 2);
				} else {
					ggc.scoreUpdate (16);
				}
			} else if (angle >= 154 && angle < 170 && position.y > 0) {
				if (dis_from_Ctr <= 2.5 && dis_from_Ctr >= 2.3) {
					ggc.scoreUpdate (8 * 3);
				} else if (dis_from_Ctr <= 3.9 && dis_from_Ctr >= 3.7) {
					ggc.scoreUpdate (8 * 2);
				} else {
					ggc.scoreUpdate (8);
				}
			} else if (angle >= 170 && angle < 180 && position.y > 0) {
				if (dis_from_Ctr <= 2.5 && dis_from_Ctr >= 2.3) {
					ggc.scoreUpdate (11 * 3);
				} else if (dis_from_Ctr <= 3.9 && dis_from_Ctr >= 3.7) {
					ggc.scoreUpdate (11 * 2);
				} else {
					ggc.scoreUpdate (11);
				}
			}

			ggc.roundCheck ();
		}
		if (col.gameObject.tag == "Ground" || col.gameObject.tag == "Walls") {
			gameObject.GetComponent<Rigidbody> ().velocity.Set (0, 0, 0);
			gameObject.GetComponent<Rigidbody> ().isKinematic = true;
			gameObject.GetComponent<Rigidbody> ().useGravity = false;
			ggc.roundCheck ();
		}
		if (col.gameObject.tag == "dart") {
			gameObject.GetComponent<Rigidbody> ().velocity.Set (0, 0, 0);
			gameObject.GetComponent<Rigidbody> ().isKinematic = true;
			gameObject.GetComponent<Rigidbody> ().useGravity = false;
			ggc.scoreUpdate (0);
			ggc.roundCheck ();
		}
	}
}
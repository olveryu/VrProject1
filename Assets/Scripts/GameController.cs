using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour {
	public Text scoreText;
	public int score;
	public Text degreeText;
	public float deg;
	public Text debugText;
	public int RoundCount;
	public Text roundText;
	private int DartCounter;
	public GameObject Dart1;
	private Vector3 Dart_1_Spawn;
	public GameObject Dart2;
	private Vector3 Dart_2_Spawn;
	public GameObject Dart3;
	private Vector3 Dart_3_Spawn;
	// Use this for initialization
	void Start () {
		score = 101;
		deg = 0;
		Dart_1_Spawn.Set (8, -5, 0); // this is telling us the x y z corrdinates of where dart 1 is to be reset at. 
		Dart_2_Spawn.Set (8, -5, 1);
		Dart_3_Spawn.Set (8, -5, -1);
		DartCounter = 0; // this counts how many times a dart hit the board.
		RoundCount = 0; // this counts up the rounds.
		scoreText.text = "score remaining: " + score;
		degreeText.text = "Degree is: " + deg;
		roundText.text = "Round " + RoundCount;
	}
	
	// Update is called once per frame
	public void scoreUpdate (int sub) {
		Debug.Log ("score update");
		score = score - sub;
		scoreText.text = "score remaining: " + score;
	}

	public void degreeUpdate (float degree){
		deg = degree;
		degreeText.text = "Degree is " + deg;
	}

	public void gameWonCheck (){
		if (score == 0) {
			
		}
	}
	public void roundCheck(){
		gameWonCheck ();
		DartCounter++;
		if (DartCounter >= 3) {
			//reset the position of dart 1 and make it non-Kinematic and use gravity again
			Dart1.transform.position = Dart_1_Spawn; 
			Dart1.gameObject.GetComponent<Rigidbody> ().isKinematic = false;
			Dart1.gameObject.GetComponent<Rigidbody> ().useGravity = true;
			//reset the position of dart 2 and make it non-Kinematic and use gravity again
			Dart2.transform.position = Dart_2_Spawn; 
			Dart2.gameObject.GetComponent<Rigidbody> ().isKinematic = false;
			Dart2.gameObject.GetComponent<Rigidbody> ().useGravity = true;
			//reset the position of dart 3 and make it non-Kinematic and use gravity again
			Dart3.transform.position = Dart_3_Spawn; 
			Dart3.gameObject.GetComponent<Rigidbody> ().isKinematic = false;
			Dart3.gameObject.GetComponent<Rigidbody> ().useGravity = true;
			//reset the dart counter
			DartCounter = 0;
			//increment the round count then print it on the game. 
			RoundCount++;
			roundText.text = "Round: " + RoundCount;
		}
	}
}

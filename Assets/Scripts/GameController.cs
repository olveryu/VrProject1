using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour {
	public Text scoreText;
	public int score;
	public Text degreeText;
	public float deg;

	// Use this for initialization
	void Start () {
		score = 101;
		deg = 0;
		scoreText.text = "score remaining: " + score;
		degreeText.text = "Degree is: " + deg;
	}
	
	// Update is called once per frame
	public void scoreUpdate (int sub) {
		Debug.Log ("score update");

		if (sub == null) {
			sub = 0; 
		}
		score = score - sub;
		scoreText.text = "score remaining: " + score;
	}

	public void degreeUpdate (float degree){
		if (degree == null) {
			deg = 0;
		}
		deg = degree;
		degreeText.text = "Degree is " + deg;
	}
}

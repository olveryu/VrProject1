using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour {
	public Text scoreText;
	private int score;

	// Use this for initialization
	void Start () {
		score = 101;
		scoreText.text = "score remaining: " + score;
	}
	
	// Update is called once per frame
	void scoreUpdate () {
		scoreText.text = "score remaining: " + score;
	}
}

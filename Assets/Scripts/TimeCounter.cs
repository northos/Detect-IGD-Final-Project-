using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeCounter : MonoBehaviour {
	public string prefix;
	public GameMenu controller;

	// Set time to 0
	void Start () {
		controller = ((GameMenu)GameObject.FindGameObjectWithTag ("GameController").GetComponent (typeof(GameMenu)));
		GetComponent<Text> ().text = prefix + (int)(controller.timeElapsed) + " seconds";
	}
	
	// Increase time by time elapsed and update display
	void Update () {
		GetComponent<Text> ().text = prefix + (int)(controller.timeElapsed) + " second" + ((int)(controller.timeElapsed) == 1 ? "" : "s");
	}
}

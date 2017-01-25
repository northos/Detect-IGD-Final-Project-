using UnityEngine;
using System.Collections;

public class GameMenu : MonoBehaviour {
	bool paused = false;
	public GameObject[] UIObjects;
	public float timeElapsed;

	// Initially hide UI, ensure time is flowing
	void Start() {
		Time.timeScale = 1;
		timeElapsed = 0;
		paused = false;
		foreach (GameObject item in UIObjects) {
			item.SetActive (paused);
		}
	}
	
	// Toggle between paused/unpaused
	public void TogglePaused(){
		paused = !paused;
		Time.timeScale = paused ? 0 : 1;
		foreach (GameObject item in UIObjects){
			item.SetActive(paused);
		}
	}

	// Pause game when Escape is pressed
	void Update () {
		timeElapsed += Time.deltaTime;
		if (Input.GetKeyDown (KeyCode.Escape)) {
			TogglePaused();
		}
	}
}

using UnityEngine;
using System.Collections;

public class MenuSway : MonoBehaviour {
	float xTime = 0.0f;
	float yTime = 0;
	public float xTimescale = 1.0f;
	public float yTimescale = 1.0f;
	public float swayscale = 10.0f;
	float xOffset = 45.0f;

	// Ensure time is running for this scene
	void Start() {
		Time.timeScale = 1;
	}
	
	// Move the flashlight sinusoidally back and forth
	void Update () {
		xTime += Time.deltaTime;
		yTime += Time.deltaTime;
		transform.rotation = Quaternion.Euler (xOffset + swayscale * Mathf.Sin (xTimescale * xTime), swayscale * Mathf.Sin (yTimescale * yTime), 0);
	}
}

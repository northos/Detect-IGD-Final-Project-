using UnityEngine;
using System.Collections;

public class FlashlightBob : MonoBehaviour {
	float yTime = 0;
	float zTime = 0.0f;
	public float yTimescale = 4.0f;
	public float zTimescale = 8.0f;
	public float bobscale = 0.01f;
	public GameObject player;
	
	// Move the flashlight sinusoidally back and forth while walking
	void Update () {
		// Check for any movement input (not rotation)
		if (Input.GetKey ("q") || Input.GetKey ("w") || Input.GetKey ("e") || Input.GetKey ("s")) {
			yTime += Time.deltaTime;
			zTime += Time.deltaTime;
			transform.Translate(0, Time.timeScale * bobscale * Mathf.Sin (yTimescale * yTime), 0);
			transform.Translate(0, 0, Time.timeScale * bobscale * Mathf.Sin (zTimescale * zTime));
		}
	}
}

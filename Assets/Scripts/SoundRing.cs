using UnityEngine;
using System.Collections;

public class SoundRing : MonoBehaviour {
	public float growSpeed = 15.0f;
	
	// Grow ring until it exceeds the size of the area
	void Update () {
		transform.localScale += new Vector3 (growSpeed * Time.deltaTime,growSpeed * Time.deltaTime, 0);
		if (transform.localScale.x >= 80){
			Destroy(gameObject);
		}
	}
}

using UnityEngine;
using System.Collections;

public class PlayerCharacter : MonoBehaviour {
	public float speed = 2.0f;
	public float angularSpeed = 200.0f;
	public Camera mainCamera;
	
	// Move the player according to WASD movement and make the camera follow the player
	void Update () {
		// Rotate right on D
		if (Input.GetKey("d")){
			transform.rotation = transform.rotation * Quaternion.AngleAxis(-angularSpeed * Time.deltaTime, new Vector3(0, 0, 1));
		}
		// Rotate left on A
		if (Input.GetKey ("a")) {
			transform.rotation = transform.rotation * Quaternion.AngleAxis(angularSpeed * Time.deltaTime, new Vector3(0, 0, 1));
		}
		// Strafe right on E
		if (Input.GetKey("e")){
			transform.Translate(new Vector3(0, -Time.deltaTime * speed, 0));
		}
		// Strafe left on Q
		if (Input.GetKey("q")){
			transform.Translate(new Vector3(0, Time.deltaTime * speed, 0));
		}
		// Move forward on W
		if (Input.GetKey("w")){
			transform.Translate(new Vector3(Time.deltaTime * speed, 0, 0));
		}
		// Move backward on S
		if (Input.GetKey("s")){
			transform.Translate(new Vector3(-Time.deltaTime * speed, 0, 0));
		}
		// Move camera to follow player (but maintain Z coordinate of -10)
		mainCamera.transform.position = transform.position - new Vector3(0, 0, 9.5f);
	}
}

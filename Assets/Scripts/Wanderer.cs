using UnityEngine;
using System.Collections;

public class Wanderer : MonoBehaviour {
	public float speed = 2.0f;
	public float maxRotate = 15.0f;
	public GameObject soundRing;
	public GameObject lightingArea;
	public GameObject[] UIObjects;
	float delay;
	public float interval = 10.0f;

	// Randomize starting position
	void Start () {
		float xPos = Random.Range (-35.0f, 35.0f);
		float yPos = Random.Range (-35.0f, 35.0f);
		transform.position = new Vector3 (xPos, yPos, transform.position.z);
		delay = 0.0f;
	}

	// When clicked, the player wins
	void OnMouseDown(){
		if (Time.timeScale != 0){
			Time.timeScale = 0;
			foreach (GameObject item in UIObjects) {
				item.SetActive (!item.activeSelf);
			}
		}
	}
	
	// Rotate by a random amount and then move forward (appears to wander)
	void Update () {
		delay -= Time.deltaTime;
		if (!lightingArea.GetComponent<PolygonCollider2D> ().bounds.Intersects (GetComponent<CapsuleCollider> ().bounds)) {
			float rotAmount = Random.Range (-maxRotate, maxRotate);
			Quaternion rot = Quaternion.AngleAxis (rotAmount * Time.timeScale, new Vector3 (0, 1, 0));
			transform.rotation = transform.rotation * rot;
			transform.Translate (speed * Time.deltaTime, 0, 0);
			if (Mathf.Abs(transform.position.x) > 40.0f){
				transform.position = new Vector3(35.0f, transform.position.y, transform.position.z);
			}
			if (Mathf.Abs(transform.position.y) > 40.0f){
				transform.position = new Vector3(transform.position.x, 35.0f, transform.position.z);
			}
		}
	}

	// Create a sound ring when the wanderer collides with anything
	// Can't happen more often than a set interval
	void OnCollisionEnter(Collision collision){
		if (delay <= 0.0f){
			GameObject temp = Instantiate (soundRing);
			temp.transform.position = collision.transform.position;
			delay = interval;
		}
	}
}

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuButton : MonoBehaviour {
	public string target;
	public Material normal;
	public Material hilite;

	// Move to game scene when mouse is clicked on box
	public void OnMouseDown(){
		if (target == "Quit") {
			Application.Quit ();
		} else {
			SceneManager.LoadScene (target);
		}
	}

	// Change appearance on mouseover
	void OnMouseEnter(){
		GetComponent<MeshRenderer> ().material = hilite;
	}

	// Change back on mouse exit
	void OnMouseExit(){
		GetComponent<MeshRenderer> ().material = normal;
	}
}

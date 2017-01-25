using UnityEngine;
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
			Application.LoadLevel (target);
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

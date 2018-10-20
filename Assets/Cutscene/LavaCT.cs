using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LavaCT : MonoBehaviour {

	public GameObject Cam1; 

	public GameObject ThePlayer;
	public GameObject TheCanvas;
	public GameObject TextBox;

	void OnTriggerEnter(){
		StartCoroutine (CutSceneShow ());
	}


	IEnumerator CutSceneShow() {
		//TheCanvas.SetActive (false);
		Cam1.SetActive (true);
		ThePlayer.SetActive (false);

		TextBox.GetComponent<Text> ().text = "Hi! Rowlet.";
		yield return new WaitForSeconds (3f);

		TextBox.GetComponent<Text> ().text = "There's Lava around here, be careful. You're a grass type Pokemon. You'll take a lot of damage. ";
		yield return new WaitForSeconds (4f);

		ThePlayer.SetActive (true);
		Cam1.SetActive (false);
		TextBox.GetComponent<Text> ().text = "";
		//TheCanvas.SetActive (true);
		Destroy (gameObject);

	}
}

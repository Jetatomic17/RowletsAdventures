using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrapCT : MonoBehaviour {

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

		TextBox.GetComponent<Text> ().text = "A spike trap!! I should avoid stepping on it";
		yield return new WaitForSeconds (5f);

		ThePlayer.SetActive (true);
		Cam1.SetActive (false);
		TextBox.GetComponent<Text> ().text = "";
		//TheCanvas.SetActive (true);
		Destroy (gameObject);

	}
}

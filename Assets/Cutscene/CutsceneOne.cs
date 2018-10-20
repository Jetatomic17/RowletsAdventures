using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutsceneOne : MonoBehaviour {

	public GameObject Cam1; //4
	public GameObject Cam2; //6
	public GameObject Cam3; //4
	public GameObject Cam4; //6.5
	public GameObject NonPlayer;
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
		NonPlayer.SetActive (true);
		TextBox.GetComponent<Text> ().text = "Whaaaa!!! I'm falling!!!";
		yield return new WaitForSeconds (4f);

		Cam2.SetActive (true);
		Cam1.SetActive (false);
		TextBox.GetComponent<Text> ().text = "Nooooo!!";
		yield return new WaitForSeconds (3f);
		TextBox.GetComponent<Text> ().text = "Whoa!!!";
		yield return new WaitForSeconds (3f);


		//Cam3.SetActive (true);
	//	Cam2.SetActive (false);
		//TextBox.GetComponent<Text> ().text = "Nooooo!!";
		//yield return new WaitForSeconds (4f);


		Cam4.SetActive (true);
		Cam2.SetActive (false);
		TextBox.GetComponent<Text> ().text = "I have to find my way back";
		yield return new WaitForSeconds (6.5f);

		NonPlayer.SetActive (false);
		ThePlayer.SetActive (true);
		Cam4.SetActive (false);
		TextBox.GetComponent<Text> ().text = "";
		//TheCanvas.SetActive (true);
		Destroy (gameObject);

	}
}

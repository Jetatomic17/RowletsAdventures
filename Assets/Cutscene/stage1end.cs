using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stage1end : MonoBehaviour {

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

		TextBox.GetComponent<Text> ().text = "This is the place! I have to go to the top of the building";
		yield return new WaitForSeconds (7.5f);

		ThePlayer.SetActive (true);
		Cam1.SetActive (false);
		TextBox.GetComponent<Text> ().text = "";
		//TheCanvas.SetActive (true);
		Application.LoadLevel (3);
		Destroy (gameObject);



	}
}

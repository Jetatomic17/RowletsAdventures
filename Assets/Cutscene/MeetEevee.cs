using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeetEevee : MonoBehaviour {

	public GameObject Cam1; //4
	public GameObject Cam2; //6

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

		TextBox.GetComponent<Text> ().text = "Hi Rowlet! You want to get back to the tree?";
		yield return new WaitForSeconds (4f);

		TextBox.GetComponent<Text> ().text = "You'll have to go up though that building";
		yield return new WaitForSeconds (4.5f);

		Cam2.SetActive (true);
		Cam1.SetActive (false);
		TextBox.GetComponent<Text> ().text = "The path might be difficult but I wish you the best of luck!";
		yield return new WaitForSeconds (4f);


	

	
		ThePlayer.SetActive (true);
		Cam2.SetActive (false);
		TextBox.GetComponent<Text> ().text = "";
		//TheCanvas.SetActive (true);
		Destroy (gameObject);

	}
}

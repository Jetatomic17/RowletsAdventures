using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalCT : MonoBehaviour {

	public GameObject Cam1; 

	public GameObject Enemy1;
	public GameObject Enemy2;
	public GameObject Enemy3;

	public GameObject EnemyNPC1;
	public GameObject EnemyNPC2;
	public GameObject EnemyNPC3;

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
		Enemy1.SetActive (false);
		Enemy2.SetActive (false);
		Enemy3.SetActive (false);

		EnemyNPC1.SetActive (true);
		EnemyNPC2.SetActive (true);
		EnemyNPC3.SetActive (true);

		TextBox.GetComponent<Text> ().text = "Hahaha Rowlet! You won't get home alive today";
		yield return new WaitForSeconds (3f);

		TextBox.GetComponent<Text> ().text = "Prepare to Die!! ";
		yield return new WaitForSeconds (3f);

		ThePlayer.SetActive (true);
		Enemy1.SetActive (true);
		Enemy2.SetActive (true);
		Enemy3.SetActive (true);

		EnemyNPC1.SetActive (false);
		EnemyNPC2.SetActive (false);
		EnemyNPC3.SetActive (false);
		Cam1.SetActive (false);
		TextBox.GetComponent<Text> ().text = "";
		//TheCanvas.SetActive (true);
		Destroy (gameObject);

	}
}

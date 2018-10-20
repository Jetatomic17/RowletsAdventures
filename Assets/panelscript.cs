using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panelscript : MonoBehaviour {

	public GameObject Panel;
	int counter;
	public InputField mainInputField;

	public void showhidePanel()
	{
		if(mainInputField.text==""){
		Debug.Log("Field is empty");
	}
	else{ 
		counter++;
		if(counter%2==1){
		Panel.gameObject.SetActive(false);
		} else {
			Panel.gameObject.SetActive(true);
		}
	}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class invertedpanelscript : MonoBehaviour {

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
		Panel.gameObject.SetActive(true);
		} else {
			Panel.gameObject.SetActive(false);
		}
	}
	}
}

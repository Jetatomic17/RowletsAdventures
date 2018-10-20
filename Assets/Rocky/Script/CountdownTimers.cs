using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimers : MonoBehaviour {
	public string levelToLoads;
	private float timers = 1f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timers -= Time.deltaTime;
		if(timers <= 0)
		{
			Application.LoadLevel(levelToLoads);
	}
}
}


﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour {

	public Image currentHealthBar;
	public Text ratioText;

	[SerializeField] private string loadLevel;

	private float hitpoint = 150;
	private float maxHitpoint = 150;

	private void Start()
	{
		UpdateHealthbar ();
	}

	private void UpdateHealthbar()
	{
		float ratio = hitpoint / maxHitpoint;
		currentHealthBar.rectTransform.localScale = new Vector3(ratio, 1, 1);
		ratioText.text = (ratio * 100).ToString("0") + '%';
	}

	private void TakeDamage(float damage)
	{
		hitpoint -= damage;
		if (hitpoint < 0)
		{
			hitpoint = 0;
			SceneManager.LoadScene(loadLevel);
			Debug.Log ("Dead");
		}

		UpdateHealthbar ();
	}

	private void HealDamage(float heal)

	{
		hitpoint += heal;
		if (hitpoint > maxHitpoint)
		{
			hitpoint = maxHitpoint;

		}
		UpdateHealthbar ();
	}
}

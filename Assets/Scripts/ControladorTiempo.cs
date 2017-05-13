﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorTiempo : MonoBehaviour {

	public Text contador;
	public Text fin;
	private float tiempo = 10f;

	// Use this for initialization
	void Start () {
		contador.text = " " + tiempo;
		fin.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		tiempo -= Time.deltaTime;
		contador.text = " " + tiempo.ToString("f0");

		if(tiempo <= 0)
		{
			contador.text = "0";
			fin.enabled = true;
		}
	}
}

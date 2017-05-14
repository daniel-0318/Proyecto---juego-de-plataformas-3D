using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class CameraController : MonoBehaviour {

	public GameObject personajePrueba;
	private int jugador_activo;
	private Vector3 offset; // posicion

	// Use this for initialization
	void Start () {

		offset = transform.position - personajePrueba.transform.position;
		//personajePrueba.SetActive (false);
	}
	
	// Update is called once per frame
	void LateUpdate () {

		try{
			Debug.Log("camera");
			Debug.Log(transform.position);
			transform.position = personajePrueba.transform.position + offset;
		}catch(Exception e){

		}

	}
}

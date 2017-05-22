using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class CameraController : MonoBehaviour {

	public GameObject []personajes;
	public GameObject jugado1;
	public GameObject jugado2;
	private Vector3 offset1; // posicion
	private Vector3 offset2; // posicion

	// Use this for initialization
	void Start () {
		Debug.Log ("Camera Controller ENTRO****");
		try{
			personajes = new GameObject[2];
			personajes[0] = GameObject.FindGameObjectWithTag("Player1");
			personajes[1] = GameObject.FindGameObjectWithTag("Player2");
			offset1 = transform.position - personajes[0].transform.position;
			offset2 = transform.position - personajes[1].transform.position;
			Debug.Log("CameraController: Tamaño lista= " + personajes.Length);
		}catch(Exception e){
			Debug.Log (e);
		}

	}
	
	// Update is called once per frame
	void LateUpdate () {
		try{
			Debug.Log("camera");
			Debug.Log(transform.position);
			if(personajes[0].activeSelf){
				transform.position = jugado1.transform.position + offset1;
			}else{
				if(personajes[1].activeSelf){
					transform.position = jugado2.transform.position + offset2;
				}
			}

		}catch(Exception e){
			Debug.Log (e);
		}

	}
}

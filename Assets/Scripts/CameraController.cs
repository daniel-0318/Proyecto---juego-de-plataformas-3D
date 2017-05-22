using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class CameraController : MonoBehaviour {

	public GameObject []personajes;
	private int jugador_activo;
	private Vector3 offset; // posicion

	// Use this for initialization
	void Start () {
		Debug.Log ("Camera Controller ENTRO****");
		try{

			personajes = GameObject.FindGameObjectsWithTag("Player");
			/*
			for(int i=0;i<personajes.Length;i++){
				if(personajes[i].activeSelf){
					jugador_activo = i;
				}
			}*/

			Debug.Log("CameraController: Tamaño lista= " + personajes.Length);
		}catch(Exception e){
			Debug.Log (e);
		}

	}
	
	// Update is called once per frame
	void LateUpdate () {

		try{
			Debug.Log("En LateUpdate la lista tiene: " + personajes.Length);
			offset = transform.position - personajes[jugador_activo].transform.position;
			Debug.Log("camera");
			Debug.Log(transform.position);
			transform.position = personajes[jugador_activo].transform.position + offset;
		}catch(Exception e){
			Debug.Log (e);
		}

	}
}

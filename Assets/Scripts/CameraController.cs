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
	public GameObject jugado3;
	private Vector3 offset1; // posicion
	private Vector3 offset2; // posicion
	private Vector3 offset3; // posicion

	// Use this for initialization
	void Start () {
		Debug.Log ("Camera Controller ENTRO****");
		try{
			personajes = new GameObject[3];
			personajes[0] = GameObject.FindGameObjectWithTag("Player1");
			Debug.Log("1");
			personajes[1] = GameObject.FindGameObjectWithTag("Player2");
			Debug.Log("2");
			personajes[2] = GameObject.FindGameObjectWithTag("Player3");
			Debug.Log("3");
			offset1 = transform.position - personajes[0].transform.position;
			Debug.Log("4");
			offset2 = transform.position - personajes[1].transform.position;
			Debug.Log("5");
			offset3 = transform.position - personajes[2].transform.position;
			Debug.Log("6");
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
			}else if(personajes[1].activeSelf){
				transform.position = jugado2.transform.position + offset2;
			}else if(personajes[2].activeSelf){
				transform.position = jugado3.transform.position + offset3;
			}

		}catch(Exception e){
			Debug.Log (e);
		}

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class CameraController : MonoBehaviour {

	public GameObject jugado1;
	public GameObject jugado2;
	public GameObject jugado3;
	private Vector3 offset1; // posicion
	private Vector3 offset2; // posicion
	private Vector3 offset3; // posicion
	private Vector3 camara;

	// Use this for initialization
	void Start () {
		//Debug.Log ("Camera Controller ENTRO****");

		try{
			jugado1 = GameObject.FindGameObjectWithTag("Player1");
			Debug.Log("1");
			jugado2 = GameObject.FindGameObjectWithTag("Player2");
			Debug.Log("2");
			jugado3 = GameObject.FindGameObjectWithTag("Player3");
			Debug.Log("3");
			offset2 = transform.position - jugado2.transform.position;
			Debug.Log("4");
			offset3 = transform.position - jugado3.transform.position;
			Debug.Log("5");
			offset1 = transform.position - jugado1.transform.position;
			Debug.Log("6");
			//Debug.Log("CameraController: Tamaño lista= " + personajes.Length);
		}catch(Exception e){
			Debug.Log (e);
		}

	}
	
	// Update is called once per frame
	void LateUpdate () {
		try{
			//Debug.Log("camera");
			//Debug.Log(transform.position);
			if(jugado1.activeSelf){
				Debug.Log("1");
				offset1 = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * 2, Vector3.up) * offset1;
				transform.position = jugado1.transform.position + offset1;
				transform.LookAt(jugado1.transform.position);

			}else if(jugado2.activeSelf){
				Debug.Log("2");
				offset2 = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * 2, Vector3.up ) * offset2;
				transform.position = jugado2.transform.position + offset2;
				transform.LookAt(jugado2.transform.position);

			}else if(jugado3.activeSelf){
				Debug.Log("3");
				offset3 = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * 2, Vector3.up ) * offset3;
				transform.position = jugado3.transform.position + offset3;
				transform.LookAt(jugado3.transform.position);
			}

		}catch(Exception e){
			Debug.Log (e);
		}

	}
}

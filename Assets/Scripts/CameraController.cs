using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CameraController : MonoBehaviour {

	public GameObject [] lista_personajes;
	private int jugador_activo;
	private Vector3 offset; // posicion

	// Use this for initialization
	void Start () {

		jugador_activo = PlayerPrefs.GetInt ("Seleccion de personaje");
		/*
		lista_personajes = new GameObject[transform.childCount];

		//Se llena la lista con los modelos (personajes)
		for (int i=0; i < transform.childCount; i++) {
			lista_personajes [i] = transform.GetChild (i).gameObject;
		}

		//desactivamos el render de los modelos (para que no se vean todos)
		foreach(GameObject go in lista_personajes){
			go.SetActive (false);
		}
*/


		Debug.Log("Tamaño "+lista_personajes.Length);
		Debug.Log(""+jugador_activo);
		if (lista_personajes.Length > 0) {
			lista_personajes [jugador_activo].SetActive (true);
			offset = transform.position - lista_personajes [jugador_activo].transform.position;
		}

	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = lista_personajes[jugador_activo].transform.position + offset;
	}
}

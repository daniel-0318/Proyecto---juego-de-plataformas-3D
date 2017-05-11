using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeleccionarPersonaje : MonoBehaviour {

	private GameObject[] lista_personajes;

	// Use this for initialization
	void Start () {
		lista_personajes = new GameObject[transform.childCount];

		//Se llena la lista con los modelos (personajes)
		for (int i; i < transform.childCount; i++) {
			lista_personajes [i] = transform.GetChild (i).gameObject;
		}

		foreach(GameObject go in lista_personajes){
			go.SetActive (false);
		}
	}

}

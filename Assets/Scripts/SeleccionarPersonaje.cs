using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeleccionarPersonaje : MonoBehaviour {

	private GameObject[] lista_personajes;

	// Use this for initialization
	void Start () {
		lista_personajes = new GameObject[transform.childCount];

		//Se llena la lista con los modelos (personajes)
		for (int i=0; i < transform.childCount; i++) {
			lista_personajes [i] = transform.GetChild (i).gameObject;
		}

		//desactivamos el render de los modelos (para que no se vean todos)
		foreach(GameObject go in lista_personajes){
			go.SetActive (false);
		}

		//activamos que solo se vea el primer personaje en la lista
		if (lista_personajes [0]) {
			lista_personajes [0].SetActive (true);
		}
	}

}

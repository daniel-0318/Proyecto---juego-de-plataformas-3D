using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeleccionarPersonaje : MonoBehaviour {

	private GameObject[] lista_personajes;
	private int index = 0;

	// Use this for initialization
	private void Start () {

		index = PlayerPrefs.GetInt ("Seleccion de personaje");

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
		if (lista_personajes [index]) {
			lista_personajes [index].SetActive (true);
		}
	}

	public void botonIzq(){
		//dejamos de mostrar el primer personaje para darle paso al siguiente.
		lista_personajes[index].SetActive(false);
		index--;
		//si estabamos parados en el primer personaje se va al ultimo.
		if (index < 0) {
			index = lista_personajes.Length - 1;
		}
		//se activa el personaje en la posicion index
		lista_personajes [index].SetActive (true);
	}

	public void botonDer(){
		//dejamos de mostrar el primer personaje para darle paso al siguiente.
		lista_personajes[index].SetActive(false);
		index++;
		//si estabamos parados en el primer personaje se va al ultimo.
		if (index == lista_personajes.Length) {
			index = 0;
		}
		//se activa el personaje en la posicion index
		lista_personajes [index].SetActive (true);
	}

	public void botonConfirmar(){
		PlayerPrefs.SetInt ("Seleccion de personaje", index);
		SceneManager.LoadScene("nivel1");
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeleccionarPersonaje : MonoBehaviour {

	public GameObject[] lista_personajes;
	public string jugador_selecionado;
	public int index = 0;

	// Use this for initialization
	private void Start () {
		jugador_selecionado = PlayerPrefs.GetString ("Seleccion de personaje");
		index = PlayerPrefs.GetInt ("Seleccion de personaje");
		Debug.Log (SceneManager.GetActiveScene ().name + " "+ jugador_selecionado +" " + index);
		if (SceneManager.GetActiveScene ().name == "Seleccion de personaje") {
			Debug.Log ("Start seleccion");
			escena_selection ();
			act_desact ();
		} else {
			Debug.Log ("Otro nivel");
			lista_personajes = new GameObject[3];
			lista_personajes[0] = GameObject.FindGameObjectWithTag("Player1");
			lista_personajes[1] = GameObject.FindGameObjectWithTag("Player2");
			lista_personajes[2] = GameObject.FindGameObjectWithTag("Player3");
			act_desact ();
		}



		Debug.Log ("SeleccionarPersonaje: Tamaño lista= " + lista_personajes.Length);
	}

	public void escena_selection(){
		lista_personajes = new GameObject[transform.childCount];

		//Se llena la lista con los modelos (personajes)
		for (int i=0; i < transform.childCount; i++) {
			lista_personajes [i] = transform.GetChild (i).gameObject;
		}
	}

	public void act_desact(){
		//desactivamos el render de los modelos (para que no se vean todos)
		foreach(GameObject go in lista_personajes){
			go.SetActive (false);
		}
		if (SceneManager.GetActiveScene ().name == "Seleccion de personaje") {
			//activamos que solo se vea el primer personaje en la lista
			if (lista_personajes [index]) {
				lista_personajes [index].SetActive (true);
			}
		} else {
			if (lista_personajes [0].tag == jugador_selecionado) {
				lista_personajes [0].SetActive (true);
			} else if (lista_personajes [1].tag == jugador_selecionado) {
				lista_personajes [1].SetActive (true);
			} else {
				lista_personajes [2].SetActive (true);
			}
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
		Debug.Log ("BotonConfirmar");
		Debug.Log (SceneManager.GetActiveScene ().name+" " +lista_personajes[index].tag + " " + index);
		PlayerPrefs.SetString("Seleccion de personaje", lista_personajes[index].tag);
		SceneManager.LoadScene("nivel1");
	}

}

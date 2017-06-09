using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Changelevel : MonoBehaviour {

	string nivel_Actual;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider jugador){
		if (jugador.gameObject.tag == "Player1" || jugador.gameObject.tag == "Player2"
			|| jugador.gameObject.tag == "Player3") {
			Debug.Log ("BRAVOOOOOOOOOO!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
			SceneManager.LoadScene ("nivel2");
		}
	}

}

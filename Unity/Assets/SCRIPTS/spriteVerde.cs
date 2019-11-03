using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteVerde : MonoBehaviour {

	public float velocidad = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.E)) {
			Debug.Log ("Hemos pulsado la tecla E");

			transform.Translate (Vector2.left * velocidad * Time.deltaTime);

		}

		if (Input.GetKey (KeyCode.F)) {
			Debug.Log ("Hemos pulsado la tecla F");

			transform.Translate (Vector2.right * velocidad * Time.deltaTime);

		}
		if (Input.GetKey (KeyCode.G)) {
			Debug.Log ("Hemos pulsado la tecla G");

			transform.Translate (Vector2.up * velocidad * Time.deltaTime);

		}
		if (Input.GetKey (KeyCode.H)) {
			Debug.Log ("Hemos pulsado la tecla H");

			transform.Translate (Vector2.down * velocidad * Time.deltaTime);

		}
		
	}
}

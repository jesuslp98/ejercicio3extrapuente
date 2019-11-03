using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteAzul : MonoBehaviour {

	public float velocidad = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.C)) {
			Debug.Log ("Hemos pulsado la tecla C");

			transform.Translate (Vector2.up * velocidad * Time.deltaTime);

		}

		if (Input.GetKey (KeyCode.D)) {
			Debug.Log ("Hemos pulsado la tecla D");

			transform.Translate (Vector2.down * velocidad * Time.deltaTime);

		}
		
	}
}

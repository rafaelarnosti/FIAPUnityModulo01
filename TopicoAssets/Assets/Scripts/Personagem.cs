using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour {

	public float velocidade;


	void OnCollisionEnter2D(Collision2D c){
		//print ("Colidi");
		print(c.gameObject.tag);

		if (c.gameObject.tag == "Bloco") {
			Destroy (c.gameObject);
		}
	}

	void OnCollisionStay2D(Collision2D c){
		print ("Estou Colidindo");
	}
	void OnCollisionExit2D(Collision2D c){
		print ("Paro");
	}

	// Use this for initialization
	void Start () {
		transform.position = new Vector2 (0.0f, 0.0f);

	}
	
	// Update is called once per frame
	void Update () {
		//transform.Rotate (Vector3.back * velocidade * Time.deltaTime);
		Vector2 movimentoPlayer = new Vector2();
		movimentoPlayer.x = Input.GetAxis("Horizontal");
		movimentoPlayer.y = Input.GetAxis ("Vertical");
		transform.Translate (movimentoPlayer *5.0f* Time.deltaTime);

		if (Input.GetButtonDown ("Jump")) {
			transform.position = Vector2.zero;
		}

	}
}

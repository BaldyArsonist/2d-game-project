using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushBack : MonoBehaviour {

	//public Rigidbody2D rb2d;
	public bool isPlayer1; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D (Collider2D coll)
	{
		string enemy;
		string poker;
		if (isPlayer1) {
			enemy = "P2";
			poker = "Pokey1";
		} else {
			enemy = "P1";
			poker = "Pokey2";
		}

		if (coll.gameObject.tag == poker) {


			//rb2d.velocity = Vector2.zero;
			//rb2d.AddForce (new Vector2 (200, 0));
			Debug.Log (coll.gameObject.name);
			//get
			//isDead = true;
			//Destroy (gameObject);
			Debug.Log (enemy + " dies");
			//transform.localScale = new Vector2 (10f, 10f);
			//transform.Translate (new Vector3 (1000, 1000, 10000));
			//transform.Translate (new Vector3 (axisX, 01) * Time.deltaTime * xspeed);
		}


	}
}

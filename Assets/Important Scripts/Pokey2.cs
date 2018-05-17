using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokey2 : MonoBehaviour {


	public Rigidbody2D poke;
	// Use this for initialization
	void Start () {
		poke = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if(coll.gameObject.tag == "P1")
		{
			//Destroy (gameObject);
			//Debug.Log("player 1 dies");
			//transform.localScale = new Vector2 (10f, 10f);
			//transform.Translate (new Vector3 (1000, 1000, 10000));
			//transform.Translate (new Vector3 (axisX, 01) * Time.deltaTime * xspeed);
		}
	}
}

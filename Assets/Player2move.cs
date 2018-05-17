using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2move : MonoBehaviour {
	public float upforce = 200f;
	private float xspeed;
	private float jump = 0f;

	public Rigidbody2D rb1d;

	private bool isDead = false;
	// Use this for initialization
	void Start () {
		rb1d = GetComponent<Rigidbody2D>();
		xspeed = 9;
	}

	// Update is called once per frame
	void Update () {
		float axisX = Input.GetAxis("Horizontal");

		transform.Translate (new Vector3 (axisX, 0) * Time.deltaTime * xspeed);
		if(Input.GetKeyDown(KeyCode.W) && jump < 2){
			rb1d.velocity = Vector2.zero;
			rb1d.AddForce (new Vector2 (0, 2*upforce));
			jump++;
		}
		if(Input.GetKeyDown(KeyCode.A)){
			transform.localScale = new Vector2 (-10f, 10f);

		}
		if(Input.GetKeyDown(KeyCode.D)){
			transform.localScale = new Vector2 (10f, 10f);

		}
	}
	void OnCollisionEnter2D(Collision2D coll)
	{
		if(coll.gameObject.tag == "Ground")
		{
			jump = 0;
		}
	}
}


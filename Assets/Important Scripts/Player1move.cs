using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1move : MonoBehaviour {
	public float upforce = 200f;
	public float downforce = -200f;
	private float xspeed;
	//private float yspeed;
	private float jump = 0f;

	public Rigidbody2D rb2d;
	public bool isPlayer1;
	public bool isPlayerT1P1;
	public bool isPlayerT2P2;

	public bool isDead = false;


	float axisX;

	KeyCode jumpKey;
	KeyCode rightKey;
	KeyCode leftKey;


	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		xspeed = 9;
		//yspeed = 9;
		if (isPlayer1) {
			if (isPlayerT1P1) {
				rightKey = KeyCode.RightArrow;
				leftKey = KeyCode.LeftArrow;
				jumpKey = KeyCode.UpArrow;
			}else{
				rightKey = KeyCode.Quote;
				leftKey = KeyCode.L;
				jumpKey = KeyCode.P;
			}
		} else {
			if (isPlayerT2P2) {
				rightKey = KeyCode.D;
				leftKey = KeyCode.A;
				jumpKey = KeyCode.W;
			}else{
				rightKey = KeyCode.H;
				leftKey = KeyCode.F;
				jumpKey = KeyCode.T;
			}
		}

	}

	// Update is called once per frame
	void Update () {
		if (isPlayer1) {
			if (isPlayerT1P1) {
				axisX = Input.GetAxis ("Horizontal2");
			}else{
				axisX = Input.GetAxis ("Horizontal3");
			}

		} else {
			if (isPlayerT2P2) {
				axisX = Input.GetAxis ("Horizontal");
			} else
				axisX = Input.GetAxis ("Horizontal4");

		}

		if(isDead){
			Destroy (gameObject);
		}


		//float axisY = Input.GetAxis("Vertical");

		transform.Translate (new Vector3 (axisX, 0) * Time.deltaTime * xspeed);
		//transform.Translate (new Vector3 (0, axisY) * Time.deltaTime * yspeed);

		if(Input.GetKeyDown(jumpKey) && jump < 2){
			rb2d.velocity = Vector2.zero;
			rb2d.AddForce (new Vector2 (0, 3*upforce));
			jump++;
		}


		if(Input.GetKeyDown(leftKey)){
			transform.localScale = new Vector2 (-10f, 10f);
		}
		if(Input.GetKeyDown(rightKey)){
			transform.localScale = new Vector2 (10f, 10f);
		}
		/*if(transform.localPosition.y == -15)
		{
			
			transform.localPosition = new Vector2 (0, 10);
		}*/
	}
	void OnCollisionEnter2D(Collision2D coll)
	{
		//Debug.Log (coll.gameObject.tag);
		if(coll.gameObject.tag == "Ground")
		{
			jump = 0;

		}
		/*if(coll.gameObject.tag == "Pokey2")
		{
			Destroy (gameObject);

			//transform.localScale = new Vector2 (10f, 10f);
			//transform.Translate (new Vector3 (1000, 1000, 10000));
			//transform.Translate (new Vector3 (axisX, 01) * Time.deltaTime * xspeed);
		}*/
	}
}

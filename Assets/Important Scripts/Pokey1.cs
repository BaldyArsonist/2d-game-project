using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI.Text;

public class Pokey1 : MonoBehaviour {

	public bool isPlayer1;
	public Rigidbody2D poke;
	public int score1 = 0;
	public int score2 = 0;
	// Use this for initialization
	void Start () {
		poke = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/*void OnTriggerEnter2D(Collider2D coll) {
		if(isPlayer1)
			if(coll.gameObject.name == "Pokey2")
			
			//Debug.Log("Dtected the correct pokey");
	}*/



	void OnCollisionEnter2D(Collision2D coll)
	{
		string enemy;
		string poker;
		string score;
		if (isPlayer1)
		{
			enemy = "P2";
			poker = "Pokey1";

		}
		else
		{
			enemy = "P1";
			poker = "Pokey2";

		}

		if(coll.gameObject.tag == poker)
		{
			
			if(isPlayer1)
			{
				score1++;
				Debug.Log (score1);
			}else{
				score2++;
				Debug.Log (score2);
			}
			Debug.Log (coll.gameObject.name);
			//get
			//isDead = true;
			//Destroy (gameObject);
			Debug.Log(enemy + " dies");
			//transform.localScale = new Vector2 (10f, 10f);
			//transform.Translate (new Vector3 (1000, 1000, 10000));
			//transform.Translate (new Vector3 (axisX, 01) * Time.deltaTime * xspeed);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class die : MonoBehaviour {
	public bool isPlayer1;
	public int score1 = 0;
	public int score2 = 0;
	public Text score1Text;
	public Text score2Text;
	// Use this for initialization
	void Start () {
		score1Text.text = score1.ToString();
		score2Text.text = score2.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	bool invincible = false;
	void OnTriggerEnter2D (Collider2D coll)
	{
		if (!invincible) {
			
			string enemy;
			string poker;
			string score;
			int startPos = 0;

			if (isPlayer1) {
				enemy = "P2";
				poker = "Pokey1";
				score = "Score1";
				startPos = -10;
			} else {
				enemy = "P1";
				poker = "Pokey2";
				score = "Score2";
				startPos = 10;
			}

			if (coll.gameObject.tag == poker || coll.gameObject.tag == "bottom") {

				invincible = true;
				Invoke ("resetInvulnerability", 2);
				transform.localPosition = new Vector2 (0, 20);

				//score.text =

				if (isPlayer1) {
					score1++;
					score1Text.text = score1.ToString ();
					Debug.Log (score1);
				} else {
					score2++;
					score2Text.text = score2.ToString ();
					Debug.Log (score2);
				}

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
		void resetInvulnerability(){
		invincible = false;
		}




}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player:MonoBehaviour {
	public float jumpheight;
	float angle = 0;
    int xSpeed = 3;
    int ySpeed = 2;

	bool isDead = false;

	public GameObject deadEffectObj;
    public GameObject itemEffectObj;

	private Rigidbody2D rb;

	GameManager gameManager;

	void Awake() {
		rb = GetComponent < Rigidbody2D > ();
	}

	// Use this for initialization
	void Start () {

	}
	// Update is called once per frame
	void Update () {
		// movePlayer();
		getInput();
	}

	void movePlayer() {
		Vector2 pos = transform.position;
		pos.x = Mathf.Cos(angle) * 3;
		// pos.y = 0;
		transform.position = pos;
		angle += Time.deltaTime * xSpeed;
    }

	void getInput() {
		if (Input.GetKeyDown(KeyCode.Space)) {
			rb.AddForce(new Vector2(0, ySpeed), ForceMode2D.Impulse);
		}
		else {
			if (rb.velocity.y > 0) {
				rb.AddForce(new Vector2(0,  -ySpeed));
			}
			else {
				rb.velocity = new Vector2(rb.velocity.x, 0);
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Milk") {
			Dead();
		}
		else if (other.gameObject.tag == "Coin") {
			GetCoin(other);
		}
		else if (other.gameObject.tag == "Platform"){
			StickToPlatform(other);
		}
		else if (other.gameObject.tag == "Spike"){
			StabOnSpike(other);
		}
	}

	void GetCoin(Collider2D other){

	}

	void StickToPlatform(Collider2D other){

	}

	void StabOnSpike(Collider2D other){

	}

	void Dead() {
        isDead = true;
        Destroy(Instantiate(deadEffectObj, transform.position, Quaternion.identity), 0.5f);
        StopPlayer();
        gameManager.CallGameOver();
    }

	void StopPlayer() {
        rb.velocity = Vector2.zero;
        rb.isKinematic = true;
    }
}

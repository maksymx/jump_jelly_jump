using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightWall : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {


	}

	void isTouching(Collider2D other) {
		Debug.Log("!!!!!!");
		if (other.gameObject.tag == "Platform") {
			Teleport(other);
		}

	}

	void Teleport(Collider2D platform){
		Vector2 pos = transform.position;
		pos.x -= 10;
		Instantiate(platform, pos, Quaternion.identity);

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Wall : MonoBehaviour {

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
		throw new NotImplementedException("The requested feature is not implemented.");
	}
}

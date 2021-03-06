﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {

	public float angle = 0;
	int xSpeed = 2;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		movePlatform();
	}

	void movePlatform() {
		Vector2 pos = transform.position;
		pos.x = Mathf.Cos(angle) * 1.5f;
		// pos.y = 0;
		transform.position = pos;
		angle += Time.deltaTime * xSpeed;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GapPlatform:MonoBehaviour {

	// Renderer m_Renderer;
	// Use this for initialization
	public bool toLeft;
	void Start () {
		// m_Renderer = GetComponent < Renderer > ();
	}

	// Update is called once per frame
	void Update () {
		if (toLeft) transform.Translate(Vector2.left * Time.deltaTime);
		else transform.Translate(Vector2.right * Time.deltaTime);
	}

	void OnBecameInvisible() {
		Debug.Log("Invisible man");
        Destroy(gameObject);
    }
}

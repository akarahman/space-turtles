using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour {

	Rigidbody2D rb;
	public Vector2 startPos;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector2 (0, -GameControl.instance.scrollSpeed);
		startPos = new Vector2 (transform.position.x, 10.7f);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (transform.position.y < -9.4f) {
			transform.position = startPos;
		}
			
	}
}

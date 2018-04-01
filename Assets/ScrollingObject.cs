using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour {

	private float scrollSpeed = -3f;
	private Rigidbody2D rb;
	private Vector2 speedVect;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		speedVect = new Vector2 (0, scrollSpeed); 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void moveAsteroid() {
		rb.velocity = speedVect;
	}
}

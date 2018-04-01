using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public static PlayerMovement instance; 
	private float transitionDuration = 0.15f;
	public Vector3 leftBound;
	public Vector3 rightBound;
	public Vector3 moveRight;

	public IEnumerator movePlayer(Vector2 distance) {

		float lerpTime = 0;
		float interpolant = 0;
		Vector2 intermediate = Vector2.zero;
		Vector2 initPos = transform.position;
		Vector2 endPos = initPos + distance;

		while(lerpTime < transitionDuration){

			lerpTime += Time.deltaTime;
			interpolant = lerpTime / transitionDuration;
			intermediate = Vector2.Lerp (initPos, endPos, interpolant);
			transform.position = intermediate;
			yield return 0;
		}
	}

	void Awake()
	{
		if (instance == null)
			instance = this;
		else if(instance != this)
			Destroy (gameObject);
	}

	// Use this for initialization
	void Start () {
		moveRight = new Vector2 (1f, 0);
		leftBound = transform.position + (-moveRight * 2);
		rightBound = transform.position + (moveRight * 2);
	}
	
	// Update is called once per frame
	void Update () {
		

	}

	public bool BoundsReached(Vector3 bound) {
		return (transform.position == bound);
	}
		
}

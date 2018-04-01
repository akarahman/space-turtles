using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	private Vector2 touchOrigin = -Vector2.one;

	// Use this for initialization
	void Start () {
		
	}
	
	void Update () {
		if (Input.touchCount > 0) {
			Touch move = Input.touches [0];

			if (move.phase == TouchPhase.Began) {
				touchOrigin = move.position;
			}

			//If the touch phase is not Began, and instead is equal to Ended and the x of touchOrigin is greater or equal to zero:
			else if (move.phase == TouchPhase.Ended && touchOrigin.x >= 0) {
				Vector2 touchEnd = move.position;

				//Calculate the difference between the beginning and end of the touch on the x axis.
				float x = touchEnd.x - touchOrigin.x;
				if (x > 100f) {
					if (PlayerMovement.instance.BoundsReached (PlayerMovement.instance.rightBound)) {
						return;
					}
					StartCoroutine (PlayerMovement.instance.movePlayer (PlayerMovement.instance.moveRight));
				} else if (x < -100f) {
					if (PlayerMovement.instance.BoundsReached (PlayerMovement.instance.leftBound)) {
						return;
					}
					StartCoroutine (PlayerMovement.instance.movePlayer (-PlayerMovement.instance.moveRight));
				} else {
					PlayerShooter.instance.shootLaser ();
				}
				touchOrigin.x = -1;
			}
		}
	}
}

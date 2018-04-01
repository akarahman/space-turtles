using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {

	public GameObject piecePrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.forward * 30, Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D coll) {

		if (coll.tag == "Laser") {
			Instantiate(piecePrefab, coll.gameObject.transform.position, Quaternion.identity);
			Destroy (coll.gameObject);
			this.gameObject.SetActive (false);
		}
	}
}

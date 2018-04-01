using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour {

	public static PlayerShooter instance; 
	public GameObject laserPrefab;

	public void shootLaser() {
		Instantiate(laserPrefab, transform.position, Quaternion.identity);
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
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

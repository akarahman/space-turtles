using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidPool : MonoBehaviour {

	private GameObject[] asteroids;
	public GameObject asteroidPrefab;
	private int asteroidPoolSize = 5;
	private float lastSpawned;
	private float spawnInterval = 1.5f;
	private int currentAsteroid;
	private Vector3 startPos;

	// Use this for initialization
	void Start () {
		asteroids = new GameObject[asteroidPoolSize];
		startPos = new Vector3 (0, 12f, 0);
		for(int i = 0; i < asteroidPoolSize; i++)
		{
			asteroids[i] = (GameObject)Instantiate(asteroidPrefab, startPos, Quaternion.identity);
		}
		lastSpawned = 0;
		currentAsteroid = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (Time.time - lastSpawned > spawnInterval) {
			asteroids [currentAsteroid].SetActive (true);
			asteroids [currentAsteroid].transform.position = new Vector3 (Random.Range (-2f, 2f), 12f, 0);
			asteroids [currentAsteroid].GetComponent<ScrollingObject> ().moveAsteroid ();
			currentAsteroid = (currentAsteroid + 1) % asteroidPoolSize;
			lastSpawned = Time.time;
		}
	}
}

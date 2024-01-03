using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
	public GameObject[] enemyPrefab;

	private float startDelay = 3f;
	private float spawnRate = 2f;
	private float range = 10f;

	void Start()
	{
		InvokeRepeating("SpawnEnemies", startDelay, spawnRate);
	}

	private void SpawnEnemies()
	{
		Vector3 spawnLocation = new Vector3(Random.Range(-range, range), 0f, Random.Range(-range, range));
		Quaternion spawnRotation = Quaternion.Euler(0f, 0f, 0f);
		Instantiate(enemyPrefab[Random.Range(0,enemyPrefab.Length)], spawnLocation, spawnRotation);
	}
}

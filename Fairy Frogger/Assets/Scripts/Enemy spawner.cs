using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyspawner : MonoBehaviour
{

	public float spawnDelay = .3f;

	public GameObject enemy;

	public Transform[] spawnPoints;

	float nextTimeToSpawn = 0f;

	void Update ()
	{
		if (nextTimeToSpawn <= Time.time)
		{
			Spawnenemy();
			nextTimeToSpawn = Time.time + spawnDelay;
		}
	}

	void Spawnenemy ()
	{
		int randomIndex = Random.Range(0, spawnPoints.Length);
		Transform spawnPoint = spawnPoints[randomIndex];

		Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
	}

}

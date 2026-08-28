using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawnerScript : MonoBehaviour
{
    List<GameObject> spawnPositions;

    [SerializeField]
    List<GameObject> asteroidsPrefabs;

    void SpawnAsteroid()
    {
        int randomAsteroid = Random.Range(0, asteroidsPrefabs.Count);
        int randomPos = Random.Range(0, spawnPositions.Count);

        Instantiate(asteroidsPrefabs[randomAsteroid], spawnPositions[randomPos].transform.position, Quaternion.identity);
    }

    void Awake()
    {
        spawnPositions = new List<GameObject>();
        foreach (Transform child in transform)
        {
            spawnPositions.Add(child.gameObject);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnAsteroid", 0, 1);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

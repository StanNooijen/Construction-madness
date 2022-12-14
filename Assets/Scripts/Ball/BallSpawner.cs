using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public float ballInterval = 3.5f;
    public Transform ballSpawnposition;

    void Start()
    {
        StartCoroutine(spawnEnemy(ballInterval, ballPrefab));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = (GameObject)Instantiate(ballPrefab, ballSpawnposition.position, Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}

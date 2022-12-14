using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public float ballInterval = 3.5f;

    void Start()
    {
        StartCoroutine(spawnEnemy(ballInterval, ballPrefab));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-28, 20), Random.Range(-28, 20), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}

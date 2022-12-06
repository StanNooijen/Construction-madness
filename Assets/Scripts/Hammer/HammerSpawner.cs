using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerSpawner : MonoBehaviour
{
    
    public GameObject hammerPrefab;
    public float hammerInterval = 3.5f;


    void Start()
    {
        StartCoroutine(spawnEnemy(hammerInterval, hammerPrefab));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-30, 30), Random.Range(55, 55), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }

}

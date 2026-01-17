using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] private float minSpawnInterval = 0.05f;
    [SerializeField] private float maxSpawnInterval = 1.5f;
    private float spawnTimer;
    private float nextSpawnTime;
    // Start is called before the first frame update
    void Start()
    {
        SetNextSpawnTime();
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= nextSpawnTime)
        {
            SpawnCoin();
            spawnTimer = 0f;
            SetNextSpawnTime();
        }

    }
    private void SpawnCoin()
    {
        Instantiate(coinPrefab, transform.position, Quaternion.identity);
    }
    private void SetNextSpawnTime()
    {
        nextSpawnTime = Random.Range(minSpawnInterval, maxSpawnInterval);
    }
}

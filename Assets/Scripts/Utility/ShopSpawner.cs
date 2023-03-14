using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSpawner : MonoBehaviour
{

    public GameObject shopPrefab;
    public Vector2 spawnArea;
    private float spawnDelay = 60f;
    // Start is called before the first frame update

    private void Awake()
    {
        spawnArea = new Vector2(10, 10);
    }

    void Start()
    {
        
        InvokeRepeating("SpawnObject", spawnDelay, spawnDelay);
    }

    private void SpawnObject()
    {
        Vector2 spawnPoint = new Vector2(Random.Range(-spawnArea.x,spawnArea.x),Random.Range(-spawnArea.y,spawnArea.y));
        Instantiate(shopPrefab,spawnPoint,Quaternion.identity);
    }
}

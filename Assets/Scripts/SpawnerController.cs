using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] float spawnInterval = 1f;
    [SerializeField] float spawnDelay = 5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnEnemy", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update() 
    {
       
        //spawnEnemy();

    }

    private void spawnEnemy()
    {
        Instantiate(enemyPrefab, transform);
    }
}

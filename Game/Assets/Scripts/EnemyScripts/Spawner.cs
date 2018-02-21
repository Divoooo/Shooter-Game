using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Spawner : MonoBehaviour {

    public GameObject enemy;

    public float spawnOffSet = 5.0f;
    public float spawnDelay = 5.0f;

    public int currentEnemyCount;
    public int currentWay = 1;

    public Action<int, int > WaveSpawner;
    public Action<int> EnemyCountDecreased;

    Vector3 randomSpawnPoint
    {
        get
        {
            int randIndex = UnityEngine.Random.Range(0, transform.childCount );
            var position =  transform.GetChild(randIndex).position + UnityEngine.Random.insideUnitSphere * spawnOffSet;
            position.y = 0;
            return position;
        }
    }
    void Start()
    {
        currentEnemyCount = currentWay * 5;
        Spawn();


    }
    void Update()
    {
        Debug.Log("currnet enemy count : " + currentEnemyCount);

        CheckSpawn();
        Debug.Log("currnet way count : " + currentWay);

    }
    private void Spawn()
    {

        if (WaveSpawner != null)
        {
            WaveSpawner(currentWay, currentEnemyCount);
        }

       // Debug.Log("Wawe Spown : "+ currentWay);

        for (int i = 0; i < currentEnemyCount; i++)
        {

            var enemyGameObject = Instantiate(enemy, randomSpawnPoint, Quaternion.identity);

            var hitDamage = enemyGameObject.GetComponent<HitDamage>();
            hitDamage.hasDied = EnemyHasDied;
        }
    }

    void EnemyHasDied()
    {
       // Debug.Log("DIED");

        currentEnemyCount--;

        if(EnemyCountDecreased != null)
        {
            EnemyCountDecreased(currentEnemyCount);
        }
    }
    public void CheckSpawn()
    {
        if (currentEnemyCount <= 0)
        {
            currentWay++;
            currentEnemyCount = currentWay * 5;
            Invoke("Spawn", spawnDelay);
        }
    }
}

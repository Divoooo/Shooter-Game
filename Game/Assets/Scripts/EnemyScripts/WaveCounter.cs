using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveCounter : MonoBehaviour {

    public Text waveNum;
    public Text enemyNum;

    Spawner spawner;

	// Use this for initialization
	void Start () {

        spawner = GetComponent<Spawner>();

        if(spawner == null)
        {
            throw new MissingComponentException("Missing Spawner Script in WaveCounter");
        }

        spawner.WaveSpawner += WaveSpawned ;
        spawner.EnemyCountDecreased += EnemyCountDecresed;

        enemyNum.text = spawner.EnemyCountDecreased.ToString();
	}
	
	// Update is called once per frame
	void WaveSpawned(int waveCount, int enemyCount) {

        waveNum.text = waveCount.ToString();
	}

    private void EnemyCountDecresed(int enemyCount)
    {
        enemyNum.text = enemyCount.ToString();
    }
}

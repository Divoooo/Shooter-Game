using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Spawner spawner;
    Text scoreLabel;
    public int ScoreVAlue {
        get { return score;  }
        set { score = value; }

    }
    int score = 0;

	// Use this for initialization
	void Start () {
        scoreLabel = GetComponent<Text>();
        spawner.EnemyCountDecreased += EnemyCountDecresed;
        if (scoreLabel == null)
        {
            throw new MissingComponentException("Missing scoreLabel in Scrore");
        }
        if (spawner == null)
        {
            throw new MissingComponentException("Missing Spawner Script in Scrore");
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void EnemyCountDecresed(int obj)
    {
        score += 10;
        scoreLabel.text = score.ToString();
    }
}

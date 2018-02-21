using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour {

    public Score score;
    public HitDamage playerDamage;

    int[] highScores;
    public int[] HighScoresList
    {
        get { return highScores; }
        set { highScores = highScores; }
    }

	// Use this for initialization
	void Start () {

        playerDamage.hasDied += PlayerHasDied;
        highScores = PlayerPrefsX.GetIntArray("HighScores");
	}

    private void PlayerHasDied()
    {

        List<int> newScores = new List<int>(highScores);
        newScores.Add(score.ScoreVAlue);
        highScores = newScores.ToArray(); 


        PlayerPrefsX.SetIntArray("HighScores",highScores);


    }
	
	
}

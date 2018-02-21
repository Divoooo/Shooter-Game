using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class HighScoreTAble : MonoBehaviour {

    Text highscoresLabel;
    HighScore highscore;

	// Use this for initialization
	void Start () {
        highscore = GameObject.Find("Score").GetComponent<HighScore>();
        highscoresLabel = GetComponent<Text>();
        if (highscore == null)
        {
            throw new MissingComponentException("Missing highscore Script in HighScoreTAble");
        }
        if (highscoresLabel == null)
        {
            throw new MissingComponentException("Missing highscoresLabel Script in HighScoreTAble");
        }
        var descendingScores = highscore.HighScoresList.OrderByDescending(d => d).ToArray();
        
        for(int i = 0; i < descendingScores.Length; i++)
        {
            var rank = i + 1;
            highscoresLabel.text += rank + ": " + descendingScores[i] + "\n";
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

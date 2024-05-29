using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManagment : MonoBehaviour
{
    public int currentScore = 0;

    private int recordScore;
    private string highscoreKey = "Highscore";

    public void WriteHighScore()
    {
        if (PlayerPrefs.HasKey(highscoreKey))
        {
            recordScore = PlayerPrefs.GetInt(highscoreKey);
            if (currentScore > recordScore)
            {
                WritePlayerPrefs();
            }
        }
        else
        {
            WritePlayerPrefs();
        }
        
    }
    private void WritePlayerPrefs()
    {
        PlayerPrefs.SetInt(highscoreKey, currentScore);
    }
}

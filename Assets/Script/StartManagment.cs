using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartManagment : MonoBehaviour
{
    [SerializeField] private Text highscoreValue;
    private string highscoreKey = "Highscore";

    private void Start()
    {
        if (PlayerPrefs.HasKey("Highscore"))
        {
            highscoreValue.text = PlayerPrefs.GetInt(highscoreKey).ToString();
        }
        else
        {
            highscoreValue.text = "0";
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}

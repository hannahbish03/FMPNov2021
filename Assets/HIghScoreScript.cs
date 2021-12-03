using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HighScoreScript : MonoBehaviour
{
    [SerializeField] GameManager gamemanager;

    [SerializeField] Text highScoreText;

    private void Update()
    {
        highScoreText.text = "HIGHSCORE: " + PlayerPrefs.GetInt("HighScore").ToString();
    }
}

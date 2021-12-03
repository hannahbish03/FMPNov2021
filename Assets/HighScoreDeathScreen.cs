using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreDeathScreen : MonoBehaviour
{
    

    [SerializeField] Text highScoreText;

    private void Update()
    {
        highScoreText.text = "HIGHSCORE: " + PlayerPrefs.GetInt("HighScore").ToString();
    }
}

using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

    public int currantScore;
    public int highScorePrefs = PlayerPrefs.GetInt("HighScore");
    public static GameManager inst;

    [SerializeField] Text currantScoreText;
    public Text currantHighScore;

    public void IncrementScore()
    {
        Debug.Log("coin pickup");
        currantScore++;
        currantScoreText.text = "SCORE: " + currantScore;

        if (currantScore >= highScorePrefs)
        {
            currantHighScore.text = highScorePrefs.ToString(); /*"HIGHSCORE: " + PlayerPrefs.GetInt("HighScore").ToString();*/
            //highScorePrefs = currantHighScore; 
            
            //need to set player pref to new high score
            //need to set player pref to new high score
            //need to set player pref to new high score
            //need to set player pref to new high score
            //need to set player pref to new high score
            //need to set player pref to new high score

            PlayerPrefs.SetInt("HighScore", currantScore);
            PlayerPrefs.Save();
        }
    }

    private void Awake()
    {
        inst = this;
    }

    void Start()
    {
        currantHighScore.text = "HIGHSCORE: " + highScorePrefs.ToString();  /*PlayerPrefs.GetInt("HighScore").ToString();*/
    }
}

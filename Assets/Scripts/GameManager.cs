using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

    public int currentScore;
    public int highScorePrefs = PlayerPrefs.GetInt("HighScore");
    public static GameManager inst;

    [SerializeField] Text currentScoreText;
    public Text currentHighScore;

    public void IncrementScore()
    {
        Debug.Log("coin pickup");
        currentScore++;
        
        highScorePrefs = PlayerPrefs.GetInt("HighScore");
        if (currentScore >= highScorePrefs)
        {
             /*"HIGHSCORE: " + PlayerPrefs.GetInt("HighScore").ToString();*/
            //highScorePrefs = currantHighScore; 

            PlayerPrefs.SetInt("HighScore", currentScore);
            PlayerPrefs.Save();
        }
    }

    private void Awake()
    {
        inst = this;
    }
    private void Update()
    {
        currentHighScore.text = "Highscore: " + highScorePrefs.ToString();
        currentScoreText.text = "SCORE: " + currentScore;
    }

    void Start()
    {
        currentHighScore.text = "HIGHSCORE: " + highScorePrefs.ToString();  /*PlayerPrefs.GetInt("HighScore").ToString();*/
    }
}

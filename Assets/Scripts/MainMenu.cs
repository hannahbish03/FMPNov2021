using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void Control()
    {
        SceneManager.LoadScene("Controls");
    }

    public void ControlBack()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Paused()
    {
        SceneManager.LoadScene("PauseScene");
    }

    public void Quit()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }



}

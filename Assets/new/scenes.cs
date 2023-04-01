using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenes : MonoBehaviour
{
    public void ToIntro()
    {
        SceneManager.LoadScene("Intro");
    }

    public void ToMain()
    {
        SceneManager.LoadScene("Main");
    }

    public void ToExit()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Exit");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }


}

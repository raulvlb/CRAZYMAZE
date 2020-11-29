using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{

    public void PlayGame()
    {

        SceneManager.LoadScene("Intro");
    }

    public void levelselect()
    {
        SceneManager.LoadScene("Level");
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    public void Play1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Play2()
    {
        SceneManager.LoadScene("Level2");
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject comands;

    // Update is called once per frame
    void Start(){
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused){
                Resume();
            }else{
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        comands.GetComponent<rota>().enabled = true;
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        comands.GetComponent<rota>().enabled = false;
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    // public void LoadMenu()
    // {
    //     Time.timeScale = 1f;
    //     SceneManager.LoadScene("Level");
    // }

    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level");
        Application.Quit();
    }

    public void Retry1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level1");
        Application.Quit();
    }

    public void Retry2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level2");
        Application.Quit();
    }

    // public void Quit()
    // {
    //     SceneManager.LoadScene("Menu");
    //     //Debug.Log("Menu");
    //     Application.Quit();
    // }
}

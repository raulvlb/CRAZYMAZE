using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject comands;

    public Animator transition;

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

    public void Menu()
    {
        transition.SetTrigger("start");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level");
    }

    public void Retry1()
    {
        transition.SetTrigger("start");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level1");
        
    }

    public void Retry2()
    {
        transition.SetTrigger("start");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level2");
        
    }

    public void Retry3()
    {
        transition.SetTrigger("start");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level3");
        
    }

    public void Retry4()
    {
        transition.SetTrigger("start");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level4");
        
    }

    public void Retry5()
    {
        transition.SetTrigger("start");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level5");
        
    }

    public void Retry6()
    {
        transition.SetTrigger("start");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level6");
        
    }
}

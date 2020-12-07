using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject comands;

    //public bool end;
    //public GameObject EndMenuUI;

    public Animator transition;

    // Update is called once per frame
    void Start(){
        GameIsPaused = false;
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
        Time.timeScale = 1f;
        GameIsPaused = true;

    }

    public void Menu()
    {
        transition.SetTrigger("start");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level");
        GameIsPaused = false;

    }

    public void Retry1()
    {
        transition.SetTrigger("start"); 
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level1");
        GameIsPaused = false;
        
    }

    public void Retry2()
    {
        transition.SetTrigger("start");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level2");
        GameIsPaused = false;
        
    }

    public void Retry3()
    {
        transition.SetTrigger("start");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level3");
        GameIsPaused = false;
        
    }

    public void Retry4()
    {
        transition.SetTrigger("start");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level4");
        GameIsPaused = false;
        
    }

    public void Retry5()
    {
        transition.SetTrigger("start");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level5");
        GameIsPaused = false;
        
    }

    public void Retry6()
    {
        transition.SetTrigger("start");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level6");
        GameIsPaused = false;
        
    }

    public void Retry7()
    {
        transition.SetTrigger("start");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level7");
        GameIsPaused = false;
        
    }

    public void Retry8()
    {
        transition.SetTrigger("start");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level8");
        GameIsPaused = false;
        
    }

    public void Retry9()
    {
        transition.SetTrigger("start");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level9");
        GameIsPaused = false;
        
    }

    public void Retry10()
    {
        transition.SetTrigger("start");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level10");
        GameIsPaused = false;
        
    }

    public void Retry11()
    {
        transition.SetTrigger("start");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level11");
        GameIsPaused = false;
        
    }

        public void Retry12()
    {
        transition.SetTrigger("start");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level12");
        GameIsPaused = false;
        
    }

        public void Retry13()
    {
        transition.SetTrigger("start");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level13");
        GameIsPaused = false;
        
    }

    //     public void Retry14()
    // {
    //     transition.SetTrigger("start");
    //     Time.timeScale = 1f;
    //     SceneManager.LoadScene("Level14");
        
    // }

    //     public void Retry15()
    // {
    //     transition.SetTrigger("start");
    //     Time.timeScale = 1f;
    //     SceneManager.LoadScene("Level15");
        
    // }
    
}

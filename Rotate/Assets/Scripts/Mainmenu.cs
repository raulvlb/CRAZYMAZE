using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;

    // Inumerator LoadLevel(int levelIndex){

    //     transition.SetTrigger("start");

    //     yield return new WaitForSeconds(transitionTime);

    // }

    public void PlayGame()
    {
        transition.SetTrigger("start");
        SceneManager.LoadScene("Intro");
    }

    public void levelselect()
    {
        transition.SetTrigger("start");
        SceneManager.LoadScene("Level");
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    public void Play1()
    {
        transition.SetTrigger("start");
        SceneManager.LoadScene("Level1");
    }

    public void Play2()
    {
        transition.SetTrigger("start");
        SceneManager.LoadScene("Level2");
    }

    public void Play3()
    {
        transition.SetTrigger("start");
        SceneManager.LoadScene("Level3");
    }

    public void Play4()
    {
        transition.SetTrigger("start");
        SceneManager.LoadScene("Level4");
    }

    public void Play5()
    {
        transition.SetTrigger("start");
        SceneManager.LoadScene("Level5");
    }

    public void Play6()
    {
        transition.SetTrigger("start");
        SceneManager.LoadScene("Level6");
    }

    public void Play7()
    {
        transition.SetTrigger("start");
        SceneManager.LoadScene("Level7");
    }

    public void Play8()
    {
        transition.SetTrigger("start");
        SceneManager.LoadScene("Level8");
    }

    public void Play9()
    {
        transition.SetTrigger("start");
        SceneManager.LoadScene("Level9");
    }

    public void Play10()
    {
        transition.SetTrigger("start");
        SceneManager.LoadScene("Level10");
    }

    public void Play11()
    {
        transition.SetTrigger("start");
        SceneManager.LoadScene("Level11");
    }

        public void Play12()
    {
        transition.SetTrigger("start");
        SceneManager.LoadScene("Level12");
    }

        public void Play13()
    {
        transition.SetTrigger("start");
        SceneManager.LoadScene("Level13");
    }

        public void Play14()
    {
        transition.SetTrigger("start");
        SceneManager.LoadScene("Level14");
    }

        public void Play15()
    {
        transition.SetTrigger("start");
        SceneManager.LoadScene("Level15");
    }

}

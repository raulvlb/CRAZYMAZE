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

}

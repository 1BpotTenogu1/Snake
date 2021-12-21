using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnPlay()
    {
        SceneManager.LoadScene(1);
    }

    public void OnExit()
    {
        Application.Quit();
    }

    public void OnWin()
    {
        SceneManager.LoadScene(1);
    }

    public void OnLose()
    {
        SceneManager.LoadScene(1);
    }

    public void OnMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void OnLevel1()
    {
        SceneManager.LoadScene(1);
    }

    public void OnLevel2()
    {
        SceneManager.LoadScene(4);
    }

    public void OnLevel3()
    {
        SceneManager.LoadScene(5);
    }
}

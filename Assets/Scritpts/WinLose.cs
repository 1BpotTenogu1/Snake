using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLose : MonoBehaviour
{
    [SerializeField] private GameObject panelPause;

    [SerializeField] private GameObject panelWin;

    [SerializeField] private GameObject panelLose;

    public void PauseOn()
    {
        panelPause.SetActive(true);
        Time.timeScale = 0;
    }

    public void PauseOff()
    {
        panelPause.SetActive(false);
        Time.timeScale = 1;
    }
    public void Win()
    {
        panelWin.SetActive(true);
    }


    public void Lose()
    {
        panelLose.SetActive(true);
    }


}

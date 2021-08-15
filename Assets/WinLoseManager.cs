using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLoseManager : MonoBehaviour
{

    public GameObject winUI;
    public GameObject loseUI;

    


    public void OpenWinScreen()
    {
        winUI.SetActive(true);

    }

    public void OpenLoseScreen()
    {
        loseUI.SetActive(true);
    }
    
    
    
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    
    
    
    public void Restart()
    {
        SceneManager.LoadScene("Level1");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level2");
    }
    
}

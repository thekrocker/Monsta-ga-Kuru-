using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLoseManager : MonoBehaviour
{

    public GameObject winUI;
    public GameObject loseUI;
    
    private int currentSceneIndex;
    


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
        SceneManager.LoadScene(0);
    }
    
    
    public void Restart()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void LoadNext()
    {
         currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
        
        Debug.Log("clicked");
    }

    public void Quit()
    {
        Application.Quit();
    }
    
}

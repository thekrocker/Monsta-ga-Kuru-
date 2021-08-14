using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class TimerCountdown : MonoBehaviour
{
    

    public TextMeshProUGUI textDisplay;
    public int secondsLeft;
    public bool takingAway;
    public bool secondsExpired = false;
    
    

    private void Start()
    {        
        
        textDisplay.text = "00:" + secondsLeft;

    }

    private void Update()
    {
        if (takingAway == false && secondsLeft > 0)
        {
            
            StartCoroutine(TimerCount());

        }
        
        
    }

    IEnumerator TimerCount()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        
        if (secondsLeft < 10)
        {
            textDisplay.text = "00:0" + secondsLeft;
        }
        else
        {
            textDisplay.text = "00:" + secondsLeft;
        }
        takingAway = false;
    }

    public bool SecondsExpired()
    {
        if (secondsLeft <= 0)
        {
            secondsExpired = true;
        }

        return secondsExpired;
    }

}

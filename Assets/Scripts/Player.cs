using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public TimerCountdown timer;

    private void Update()
    {
        if (timer.SecondsExpired())
        {
            Destroy(gameObject);
        }
    }
}

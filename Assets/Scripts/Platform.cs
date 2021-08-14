using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{


    public bool isInsidePlatform;
   
    

    private void Start()
    {
        isInsidePlatform = false;
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        isInsidePlatform = true;
        Debug.Log("First Script when triggered:" + isInsidePlatform);

    }

    public void OnTriggerExit2D(Collider2D other)
    {
        isInsidePlatform = false;
        Debug.Log("Leaving" + other.gameObject.name);
    }
}

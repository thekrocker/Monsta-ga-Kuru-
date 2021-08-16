using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class LevelManager : MonoBehaviour
{


    [SerializeField] private GameObject hazard;
    [SerializeField] private Transform hazardSpawn;

    public bool isHazardActive;
    public enum LevelState
    {
        Level1,
        Level2,
        Level3,
        Level4,
        Level5
    }

    public LevelState levelstate;

    private void Start()
    {
        switch (levelstate)
        {
            case LevelState.Level1:
                Debug.Log("It's level 1.");
                break;
            
            case LevelState.Level2:
                // Do things.

                isHazardActive = true;
                Debug.Log("It's level 2.");
                break;
            
            case LevelState.Level3:
                // Do things.
                break;
            
            case LevelState.Level4:
                // Do things.
                break;
            
            case LevelState.Level5:
                // Do things.
                break;
            
            
        }
    }

    private void Update()
    {
      
        
    }

}


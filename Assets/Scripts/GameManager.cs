using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    [SerializeField] private Player playerPrefab;
    [SerializeField] private Transform playerSpawnPoint;


    private void Start()
    {

        
        Player player = Instantiate(playerPrefab, playerSpawnPoint.position, Quaternion.identity);
        player.GetComponent<Player>();
        
        

    }
}

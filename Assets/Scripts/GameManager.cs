using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class GameManager : MonoBehaviour
{


    [SerializeField] private Player playerPrefab;
    [SerializeField] private Transform playerSpawnPoint;

    [SerializeField] private Innocent innocents;
    [SerializeField] private Transform[] innocentSpawnPoints;

    public int respawnNumber; // how many enemies to respawn
    


    private void Start()
    {
        RespawnMonster();
        
        RespawnInnocents();
    }

    private void RespawnMonster()
    {
        Player player = Instantiate(playerPrefab, playerSpawnPoint.position, Quaternion.identity);
        player.GetComponent<Player>();
        player.range = 5;
        Debug.Log(player.range);
    }


    private void RespawnInnocents()
    {

        for (int i = 0; i < respawnNumber; i++)
        {
            Innocent innocent = Instantiate(innocents, innocentSpawnPoints[i].position, Quaternion.identity);
            innocent.GetComponent<Innocent>();
        }
    }
    
}

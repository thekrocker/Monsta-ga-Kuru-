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


    private Player _player;


    private void Start()
    {
        RespawnPlayer();
        
        RespawnInnocents();
        
        
    }

    private void RespawnPlayer()
    {
        _player = Instantiate(playerPrefab, playerSpawnPoint.position, Quaternion.identity);
        _player.GetComponent<Player>();
        _player.range = 5;
        Debug.Log(_player.range);
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

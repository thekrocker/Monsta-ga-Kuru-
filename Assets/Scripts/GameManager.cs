using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class GameManager : MonoBehaviour
{

    private Player _player;
    [SerializeField] private Transform playerSpawnPoint;

    [SerializeField] private Monster monsterPrefab;
    private Monster _monster;
    private bool _isMonsterSpawned;
    public TimerCountdown timer;
    
    
    [SerializeField] private Innocent innocents;
    [SerializeField] private Transform[] innocentSpawnPoints;
    


    public int respawnNumber; // how many enemies to respawn
    
    public Platform platform;


    private void Start()
    {

        RespawnInnocents();
        
    }

    private void Update()
    {
        
        if (timer.SecondsExpired() && !_isMonsterSpawned)
        {
            SpawnMonster();
            _isMonsterSpawned = true;
        }
        
        
    }

    


    private void RespawnInnocents()
    {

        for (int i = 0; i < respawnNumber; i++)
        {
            Innocent innocent = Instantiate(innocents, innocentSpawnPoints[i].position, Quaternion.identity);
            innocent.platform = this.platform;
        }
    }

    private void SpawnMonster()
    {
        
        _monster = Instantiate(monsterPrefab, playerSpawnPoint.position, Quaternion.identity);
        _monster.GetComponent<Monster>();
        
    }
    
    


    
    
    
}

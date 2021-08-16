using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class Monster : MonoBehaviour
{

    [SerializeField] private float range;
    private WinLoseManager _winLoseManager;
    private Vector3 _a;
    private Vector3 _b;
    [SerializeField] private float speed;

    GameManager _gameManager;

    private int _innocentIndex = 0;

    private bool _isGameOver;
    

    private void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        _winLoseManager = GameObject.Find("WinLoseManager").GetComponent<WinLoseManager>();
        StartCoroutine(MoveCoroutine());
    }

    
    IEnumerator MoveCoroutine()
    {
        yield return new WaitForSeconds(3);

        while (true)
        {
            MoveToInnocents();
            yield return null;
        }

    }
    
    
    private void MoveToInnocents()
    {
        
        
        if (_innocentIndex <= _gameManager.İnnocentList.Count - 1)
        {
            var targetPosition = _gameManager.İnnocentList[_innocentIndex].transform.position;
            var movementThisFrame = speed * Time.deltaTime;
            
            
            
            if (Vector3.Distance(transform.position, targetPosition) < range) // If its range.. Go and kill it.
            {
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, movementThisFrame);
                
                if (transform.position == targetPosition)
                {
                    _gameManager.İnnocentList[_innocentIndex].gameObject.SetActive(false);
                    // Sound effect Innocent
                    if (_gameManager.innocent.gameObject.activeSelf)
                    {
                        _gameManager.innocent.GetComponent<AudioSource>().Play();
                    }
                    _innocentIndex++;
                }
                
            }

            
            if (Vector3.Distance(transform.position, targetPosition) > range) // If Out of Range, check for it and go.
            {
                _innocentIndex++;
                
                if (Vector3.Distance(transform.position, targetPosition) < range)
                {
                    transform.position = Vector3.MoveTowards(transform.position, targetPosition, movementThisFrame);
                }
            }
        }
        
        else
        {
            bool allActive = true;

            foreach (Innocent obj in _gameManager.İnnocentList)
            {
                if (!obj.gameObject.activeSelf)
                {
                    allActive = false;
                    break;
                }
            }

            if (allActive) // If you win.
            {
                // win screen
                _winLoseManager.OpenWinScreen();
                
            }

            else
            {
                _winLoseManager.OpenLoseScreen();

            }

        }

    }
    
}


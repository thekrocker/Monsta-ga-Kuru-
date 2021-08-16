using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{


    public Transform[] patrolPoints;
    public float speed;
    private int _currentPointIndex;

    private void Start()
    {
        transform.position = patrolPoints[0].position;
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, patrolPoints[_currentPointIndex].position,
            speed * Time.deltaTime);

        if (transform.position == patrolPoints[_currentPointIndex].position)
        {
            if (_currentPointIndex + 1 < patrolPoints.Length)
            {
                _currentPointIndex++;
            } else
            {
                _currentPointIndex = 0;
            }
        }
    }
}

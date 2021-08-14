using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{

    [SerializeField] private float range;


    private Vector3 _a;
    private Vector3 _b;
    [SerializeField] private float speed;

    
    

    private void Update()
    {

        foreach (Innocent innocent in Innocent.GetInnocentList())
        {
            _a = transform.position;
            _b = innocent.transform.position;

            if (Vector3.Distance(_a, _b) < range)
            {
                
                 transform.position = Vector3.MoveTowards(_a, _b, speed * Time.deltaTime);
                 


            }
        }
    }
}

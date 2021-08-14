using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Innocent : MonoBehaviour
{
    private Vector3 _dragOffset;
    private bool _selected;
    private Camera _camera;
    
    public Platform platform;



    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Start()
    {
    }


    private void Update()
    {

        if (_selected)
        {
            
            // transform.position = new Vector2(GetMousePos().x, GetMousePos().y);
            transform.position = GetMousePos() + _dragOffset;
        }

        if (Input.GetMouseButtonUp(0) && platform.isInsidePlatform)
        {
            _selected = false;
        }
            
    }
    private void OnMouseDown()
    {
        _dragOffset = transform.position - GetMousePos();
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _selected = true;
        }
            
    }
    

    private Vector3 GetMousePos()
    {
        var mousePos = _camera.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }
    
    
}


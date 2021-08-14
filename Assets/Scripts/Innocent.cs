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

    private bool _isPlaced;

    private bool _isInsidePlatform;

    private Vector3 _resetPosition;


    private void Awake()
    {
        _isInsidePlatform = false;
        _resetPosition = transform.position;
        _camera = Camera.main;

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("EscapePlatform"))
        {
            _isInsidePlatform = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("EscapePlatform"))
        {
            _isInsidePlatform = false;
        }
    }


    private void Update()
    {

        if (_selected)
        {
            // transform.position = new Vector2(GetMousePos().x, GetMousePos().y);
            transform.position = GetMousePos() + _dragOffset;
        }
        
        
            
    }
    private void OnMouseUp()
    {
        if (_isInsidePlatform) // Check if OnTriggerEnter2D is true.
        {
            _isPlaced = true;
            _selected = false;
        }
        else
        {
            _selected = false;
            this.transform.localPosition = new Vector3(_resetPosition.x, _resetPosition.y, _resetPosition.z);
            
        }


    }


    private void OnMouseDown()
    {
         _dragOffset = transform.position - GetMousePos();
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && !_isPlaced)
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


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Innocent : MonoBehaviour
{
     private Vector3 _dragOffset;
     private bool _selected;
    private Camera _camera;
    private float _startPosX, _startPosY;
    public bool moving;



        private void Awake()
    {
        _camera = Camera.main;
    }


        private void Update()
        {
            if (_selected)
            {
                
                // transform.position = new Vector2(GetMousePos().x, GetMousePos().y);
                transform.position = GetMousePos() + _dragOffset;
            }
            
            

            
        }

        
        private void OnMouseDown()
        {

            _dragOffset = transform.position - GetMousePos();
            _selected = true;
        }

        private void OnMouseUp()
        {
            _selected = false;
        }


        private Vector3 GetMousePos()
        {
            var mousePos = _camera.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
            return mousePos;
        }
    }


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    private Vector3 lastClickedPos;
    
    private bool moving;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moving = true;
        }

        if (moving && transform.position != lastClickedPos)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, lastClickedPos, step);
            
        }
        else
        {
            moving = false;
        }
    }
}
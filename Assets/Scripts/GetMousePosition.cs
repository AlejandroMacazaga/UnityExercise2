using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class GetMousePosition : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = Input.mousePosition;
        Rect screenRect = new Rect(0,0, Screen.width, Screen.height);
        if (!screenRect.Contains(Input.mousePosition))
            return;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        gameObject.transform.position = mousePosition;
    }



}

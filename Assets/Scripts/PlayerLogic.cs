using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerLogic : MonoBehaviour
{
    [SerializeField] private PlayerData playerData;

    private Camera _camera;

    private bool _canBeHit = true;
    void Start()
    {
        _camera = Camera.main;
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = Input.mousePosition;

        // Stop movement when the mouse leaves the camera rectangle
        Rect screenRect = new Rect(0,0, Screen.width, Screen.height);
        if (!screenRect.Contains(Input.mousePosition))
            return;
        mousePosition = _camera.ScreenToWorldPoint(mousePosition);

        gameObject.transform.position = mousePosition;
    }


    void OnCollisionEnter2D(Collision2D collision2D)
    {
        switch (collision2D.gameObject.tag)
        {
            case "Powerup": 
                Destroy(collision2D.gameObject);
                playerData.currentLife += 1;
                break;
            case "Enemy":
                if (_canBeHit)
                {
                    playerData.currentLife -= 1;
                    _canBeHit = false;
                    StartCoroutine(SetTrue());
                }
                if (playerData.currentLife <= 0)
                {
                    Application.Quit();
                }

                break;
        }
        
    }

    IEnumerator SetTrue()
    {
        yield return new WaitForSeconds(2); //wait 10 seconds
        _canBeHit = true;
    }
}

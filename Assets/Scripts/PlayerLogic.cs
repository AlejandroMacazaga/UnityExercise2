using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using Cursor = UnityEngine.UIElements.Cursor;

public class PlayerLogic : MonoBehaviour
{
    [SerializeField] private PlayerData playerData;
    [SerializeField] private GameObject deathMenu;
    private Camera _camera;
    public int _gameScore;
    private bool _canBeHit = true;
    private int _currentLife;
    void Start()
    {
        _camera = Camera.main;
        _gameScore = 0;
        _currentLife = playerData.currentLife;
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
                _currentLife += 1;
                StartCoroutine(SlowTime());
                _gameScore += 10;
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
                    GameEnd();
                }

                break;
        }
        
    }

    void GameEnd()
    {
        deathMenu.SetActive(true);
        Time.timeScale = 0f;
        Destroy(gameObject);
        deathMenu.GetComponent<DeathMenuLogic>().SetScore(_gameScore);
        GameObject.FindWithTag("GameManager").GetComponent<GameManager>().AddScore(_gameScore);
    }

    IEnumerator SetTrue()
    {
        yield return new WaitForSeconds(2); //wait 10 seconds
        _canBeHit = true;
    }

    IEnumerator SlowTime()
    {
        Time.timeScale = 0.5f;
        yield return new WaitForSeconds(3);
        Time.timeScale = 1f;
    }
}

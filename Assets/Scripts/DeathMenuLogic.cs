using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenuLogic : MonoBehaviour
{
    private int _score;
    [SerializeField] private TextMeshProUGUI _scoreText;
    
    
    public void MainMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void RestartGame()
    {
        GameManager.Instance.AddScore(_score);
        SceneManager.LoadScene("MainScene");
    }

    public void SetScore(int score)
    {
        
        this._score = score;
        _scoreText.text = "Score: " + score;
    }
}

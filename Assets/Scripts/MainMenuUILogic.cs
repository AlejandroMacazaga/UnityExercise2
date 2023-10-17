using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUILogic : MonoBehaviour
{
    [SerializeField] private GameObject gameManager;
    [SerializeField] private TextMeshProUGUI scoreText;
    private void Start()
    {
        List<int> score = gameManager.GetComponent<GameManager>().Get5BestScores();
        string scoreString = "";
        for (int i = 0; i < score.Count; i++)
        {
            scoreString += (i + 1) + ". " + score[i] + "\n";
        }

        scoreText.text = scoreString;
    }

    public void StopGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public List<int> highScores = new List<int>();
    private void Start()
    {
        
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public List<int> Get5BestScores()
    {
        highScores.Sort();
        Debug.Log(highScores);
        return highScores;
    }
    
    public void AddScore(int score)
    {
        highScores.Add(score);
    }
}

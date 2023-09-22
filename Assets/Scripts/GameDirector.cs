using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameDirectorScript : MonoBehaviour
{
    [SerializeField] private GameData gameData;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        
        for (int i = 0; i < gameData.maxNumberOfEnemies; i++)
        {
            SpawnEnemy();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnEnemy()
    {
        
    }
}

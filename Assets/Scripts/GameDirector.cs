using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameDirectorScript : MonoBehaviour
{
    // Script for controlling the flow and difficulty of the game in a centralized game object
    [SerializeField] private GameData gameData;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        
        for (int i = 0; i < gameData.maxNumberOfEnemies; i++)
        {
            SpawnEnemy(gameData.enemySpawnPositions[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnEnemy(Vector2 position)
    {
        Instantiate(gameData.enemy, position, Quaternion.identity);
    }

    private void SpawnPowerup(Vector2 position)
    {
        Instantiate(gameData.powerup, position, Quaternion.identity);
    }

    private IEnumerator CoroutineEnemySpawn()
    {
        GameObject[] listOfEnemies = GameObject.FindGameObjectsWithTag(gameData.enemy.tag);
        if (listOfEnemies.Length < gameData.maxNumberOfEnemies)
        {
            // Spawn enemy on random position inside rectangle

            yield return new WaitForSeconds(10.0f);
        }
        yield return null;
    }

    private IEnumerator CoroutinePowerupSpawn()
    {
        // Spawn powerup on random position inside rectangle
        
        yield return new WaitForSeconds(25.0f);
    }
}

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
        
        for (int i = 0; i < gameData.currentNumberOfEnemies; i++)
        {
            SpawnEnemy(gameData.enemySpawnPositions[i]);
        }

        StartCoroutine(CoroutinePowerupSpawn());
        StartCoroutine(CoroutineEnemySpawn());
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
        Debug.Log("Enemy spawn coroutine");
        if (gameData.currentNumberOfEnemies <= gameData.maxNumberOfEnemies)
        {
            // Spawn enemy on random position inside rectangle
            SpawnEnemy(
                gameData.enemySpawnPositions[Random.Range(0, gameData.enemySpawnPositions.Length)]);
            yield return new WaitForSeconds(10.0f);
        }
        yield return null;
    }

    private IEnumerator CoroutinePowerupSpawn()
    {
        
        Debug.Log("Powerup spawn coroutine");
        // Spawn powerup on random position inside rectangle
        Rect screenRect = new Rect(0,0, Screen.width, Screen.height);
        SpawnPowerup(gameData.enemySpawnPositions[Random.Range(0, gameData.enemySpawnPositions.Length)]);
        yield return new WaitForSeconds(25.0f);
    }
}

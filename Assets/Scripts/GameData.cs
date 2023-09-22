using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Scripts/GameData", menuName = "ScriptableObjects/GameData", order = 1)]
public class GameData : ScriptableObject
{
    public int maxNumberOfEnemies;
    public int currentNumberOfEnemies;
    public GameObject enemy;
    public Vector2[] enemySpawnPositions;
}

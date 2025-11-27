using UnityEngine;
using UnityEngine.Events;

public class Gamemanager : MonoBehaviour
{
[SerializeField]
private GameData gameData;
[SerializeField]
private EnemyManager enemyManager;
[SerializeField]
private UnityEvent onWinGame;
[SerializeField]
private UnityEvent onLosegame;
public void StartLevel()
    {
        LevelData currentLevel = gameData.levels[gameData.currentLevelIndex];
        enemyManager.SetEnemiesToSpawn(currentLevel.enemiesToSpawn);
        enemyManager.StartSpawningEnemies();
    }
    public void WinGame()
    {
        onWinGame?.Invoke();
    }
    public void LoseGame()
    {
        onLosegame?.Invoke();
    }
}

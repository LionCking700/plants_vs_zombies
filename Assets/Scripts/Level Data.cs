using UnityEngine;
[CreateAssetMenu(fileName = "LevelData", menuName = "Scriptable Objects/Leveldata")]
public class LevelData : ScriptableObject
{
    public InstantiateEnemy[] enemiesToSpawn;
    public PlantType[] availablePlants;
}

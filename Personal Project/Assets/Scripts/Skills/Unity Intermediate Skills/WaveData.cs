using System.Diagnostics.Contracts;
using UnityEngine;

[CreateAssetMenu(fileName = "WaveData", menuName = "Scriptable Objects/WaveData")]
public class WaveData : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int enemyCount;
    public float enemySpacing;
    public float enemyRespawnTime;
    public float enemyHealth;
    public int currencyPerEnemy;
    public float enemySpeed;
}

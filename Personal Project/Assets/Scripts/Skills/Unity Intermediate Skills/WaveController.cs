using UnityEngine;

public class WaveController : MonoBehaviour
{
    public WaveData wavedata;

    void Start()
    {
        for (int i = 0; i < wavedata.enemyCount; ++i)
        {
            Instantiate(wavedata.enemyPrefab);
        }
    }
}

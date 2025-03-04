using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{

    private Vector3 startingPosition;
    private Vector3 roamPosition;

    private void Start()
    {
        // Sets startingPosition as whatever the position is when you press play
        startingPosition = transform.position;

        roamPosition = GetRoamingPosition();
    }

    private void Update()
    {
        
    }

    // Makes a roaming position using the startingPosition, a random direction, and a random value ranging from 11-70
    private Vector3 GetRoamingPosition()
    {
        return startingPosition + GetRandomDir() * Random.Range(10f, 70f);
    }

    // Creates a new static Vector3 that generates a random direction
    private static Vector3 GetRandomDir()
    {
        return new Vector3(UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-1f, 1f)).normalized;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatRoomTrigger : MonoBehaviour
{
    public bool playerInsideRoom;

    public event EventHandler OnPlayerEnterTrigger;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        // Check if object has the Player tag then check if it's inside the collider or not
        if (collider.CompareTag("Player"))
        {
            Movement player = collider.GetComponent<Movement>();

            if (player != null)
            {
                //Player inside trigger area
                Debug.Log("Player entered cat room");

                playerInsideRoom = true;
            }
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Player exited cat room");
        playerInsideRoom = false;
    }
}

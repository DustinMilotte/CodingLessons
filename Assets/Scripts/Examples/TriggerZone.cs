using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    public int zoneNumber;
    // private GameManager gameManager;

    private void Awake()
    {
        // gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // only if the player runs into trigger
        if (other.CompareTag("Player"))
        {
            // gameManager.SpawnObject(zoneNumber);
        }
    }
}

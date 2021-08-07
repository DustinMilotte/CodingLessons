using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayerDone : MonoBehaviour
{
    public GameObject player;
    public Transform spawnPosition;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Instantiate(player, spawnPosition.position, Quaternion.identity);
        }
    }
}

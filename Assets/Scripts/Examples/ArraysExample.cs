using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using TMPro;
using UnityEngine;

public class ArraysExample : MonoBehaviour
{
    // this is our array of strings, we will populate it in the inspector
    public string[] teamNames;

    public GameObject[] objectsToSpawn;
    
    public GameObject displayCanvas;
    public TextMeshProUGUI displayText;
    public int teamNameIndex;
    public float timeToWait;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            StartCoroutine(DisplayTeamName());
        }
    }

    IEnumerator DisplayTeamName()
    {
        // if the canvas is not active
        if (!displayCanvas.activeInHierarchy)
        {
            // turn it on
            displayCanvas.SetActive(true);
        }
        
        // for each name in the array
        for (int i = 0; i < teamNames.Length; i++)
        {
            // make the string have the right team name
            string favTeam = ("My favorite team is: " + teamNames[i]);
            print(favTeam); 
            // set the display text
            displayText.text = favTeam;
            // wait a certain amount of time
            yield return new WaitForSeconds(timeToWait);
        }
    }
}
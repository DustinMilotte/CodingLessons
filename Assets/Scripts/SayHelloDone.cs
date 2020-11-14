using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SayHelloDone : MonoBehaviour
{
    public string bubbleText;
    public float speeachBubbleTimer = 5f;
    public Canvas speechBubble;
    private string[] teamNames = new[] {"Yankees", "Braves", "Mets"};
    private int[] numbers = {1, 3, 5};
    public TextMeshProUGUI display;
    public int teamNameIndex;
    
    public TextMeshProUGUI playerSpeechText;
    
    private bool showingText = false;
    private float timeSinceTextAppeared = 0f;

    private void Start()
    {
        string favTeam = ("My favorite team is: " + teamNames[teamNameIndex]);
        display.text = favTeam;
        // numbers[2];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ShowPlayerText();
        }

        if (showingText)
        {
            // add the time since last frame to our timer variable
            timeSinceTextAppeared += Time.deltaTime;
            
            // if our speech bubble has shown for longer than our timer
            if (timeSinceTextAppeared >= speeachBubbleTimer)
            {
                timeSinceTextAppeared = 0f;
                speechBubble.enabled = false;
                showingText = false;
            }
        }
    }
    
    // Show the player's speech bubble
    private void ShowPlayerText()
    {
       
        if (!showingText)
        {
            // update the text in our text mesh pro component
            // playerSpeechText.text = bubbleText;
            // show text canvas
            speechBubble.enabled = true;
            showingText = true;
        }
    }
}

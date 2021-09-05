using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpeechBubble : MonoBehaviour
{
    public TextMeshProUGUI playerSpeechText;
    public Canvas speechBubble;
    public string playerText;
    public bool isShowingText;
    public float timeSinceTextAppeared = 0f;
    public float speechTimer;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ShowPlayerText();
        }
        
        TurnOffSpeechBubble();
        
    }

    // Display the players text in a speech box
    private void ShowPlayerText()
    {
        print("test");
        isShowingText = true;

        // update the text in our text component
        playerSpeechText.text = playerText;
        
        // show the text canvas
        speechBubble.enabled = true;

    }

    private void TurnOffSpeechBubble()
    {
        if (isShowingText)
        {
            // add the time since last frame to our timer variable
            timeSinceTextAppeared += Time.deltaTime;
            
            // if our speech bubble has shown for longer than our speech timer
            if (timeSinceTextAppeared >= speechTimer)
            {
                // turn it off and reset our variables
                speechBubble.enabled = false;
                timeSinceTextAppeared = 0f;
                isShowingText = false;
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;
    
    private void OnTriggerEnter(Collider other)
    {
        // If a ball enters the collider
        if (other.gameObject.CompareTag("Ball"))
        {
            score += 1;
            UpdateScore();
        }
    }

    private void UpdateScore()
    {
        scoreText.text = score.ToString();
    }
}
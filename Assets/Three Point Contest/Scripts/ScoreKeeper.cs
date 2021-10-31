using TMPro;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            UpdateScore();
        }
    }

    private void UpdateScore()
    {
        score += 1;
        scoreText.text = score.ToString();
    }
}
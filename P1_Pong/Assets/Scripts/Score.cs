using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score = 0;

    public TextMeshProUGUI scoreText;

    public void IncreaseScore()
    {
        score++;
        Debug.Log("Score is now: " + score);
        UpdateScore();
    }

    public void ResetScore()
    {
        score = 0;
        UpdateScore();
    }

    private void UpdateScore()
    {
        scoreText.text = score.ToString();
    }
}
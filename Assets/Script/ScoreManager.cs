using UnityEngine;
using TMPro; // Required for TextMeshPro components
using UnityEngine.SceneManagement; // Required to load scenes

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Use TextMeshProUGUI for TextMeshPro elements

    public int score = 0;
    public int maxScore = 20; // Maximum score before triggering game over

    public Timer timer; // Reference to the Timer script




    public void AddScore(int value)
    {
        score += value;
        UpdateScoreUI();
        if (score >= maxScore)
        {
            GameOver();
        }
    }

    public void SubtractScore(int value)
    {
        score -= value;
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    private void GameOver()
    {
        if (timer != null)
        {
            timer.StopTimer(); // Stop the timer
        }

        // Load the Game Over scene
        SceneManager.LoadScene("GameOver");
    }
}


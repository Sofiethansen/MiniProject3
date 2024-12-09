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
        // Increase the score
        score += value;
        // Check if the score has reached or exceeded the maximum score.
        UpdateScoreUI();
        if (score >= maxScore)
        {
            //Trigger the game over if maximum score is reached 
            GameOver();
        }
    }

    public void SubtractScore(int value)
    {
        //Decrease score
        score -= value;
        UpdateScoreUI();
    }
 
    private void UpdateScoreUI()
    {
        // Ensure the scoreText UI element is not null to avoid errors.
        if (scoreText != null)
        {
            // Update the text of the score UI element to reflect the current score.
            scoreText.text = "Score: " + score;
        }
    }
    // Private method to handle Game Over
    private void GameOver()
    {
        // If a timer exists, stop it.
        if (timer != null)
        {
            timer.StopTimer(); // Stop the timer
        }

        // Load the Game Over scene
        SceneManager.LoadScene("GameOver");
    }
}


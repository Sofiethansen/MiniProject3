using UnityEngine;
using TMPro; // Required for TextMeshPro elements

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText; // UI Text element to display the timer
    private float elapsedTime = 0f; // Time elapsed in seconds
    private bool isTimerRunning = false; // Flag to start/stop the timer

    private void Start()
    {
        StartTimer(); // Start the timer when the game begins
    }

    private void Update()
    {
        if (isTimerRunning)
        {
            elapsedTime += Time.deltaTime; // Increment time by the time since last frame
            UpdateTimerUI(); // Update the timer display
        }
    }

    public void StartTimer()
    {
        elapsedTime = 0f; // Reset the timer
        isTimerRunning = true;
    }

    public void StopTimer()
    {
        isTimerRunning = false; // Stop the timer
    }

    private void UpdateTimerUI()
    {
        // Format time as minutes:seconds and update the text
        int minutes = Mathf.FloorToInt(elapsedTime / 60f);
        int seconds = Mathf.FloorToInt(elapsedTime % 60f);
        timerText.text = $"Time: {minutes:00}:{seconds:00}";
    }
}

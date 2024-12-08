using UnityEngine;

public class RubberDuckPickup : MonoBehaviour
{
    public int scoreValue = 1; // Points awarded for picking up a rubber duck
    private bool canPickUp = false; // Flag to track if the player can pick up the duck

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canPickUp = true; // Player entered the trigger zone
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canPickUp = false; // Player left the trigger zone
        }
    }

    private void Update()
    {
        if (canPickUp && Input.GetKeyDown(KeyCode.E)) // Check if "E" is pressed and player is in range
        {
            // Add score to the player
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            if (scoreManager != null)
            {
                scoreManager.AddScore(scoreValue); // Correctly call AddScore
            }

            // Destroy the rubber duck
            Destroy(gameObject);
        }
    }
}



using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemySpawner spawner; // Reference to the spawner script
    public Transform player; // Reference to the player's transform
    public float speed = 5f; // Speed at which the enemy moves

    void Update()
    {
        if (player != null)
        {
            // Calculate the direction toward the player
            Vector3 direction = (player.position - transform.position).normalized;

            // Move the enemy towards the player
            transform.position += direction * speed * Time.deltaTime;
        }
    }
    // This method is called automatically by Unity when the GameObject this script is attached to is destroyed.
    void OnDestroy()
    {
        // Check if the spawner reference is not null, if it exist and is assigned
        if (spawner != null)
        {
            // If the spawner exists, call its method to spawn an enemy after a delay.
            spawner.SpawnEnemyWithDelay();
        }
    }
    //when an object collides with another object.
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the object this collided with has the tag "Player".
        if (collision.gameObject.CompareTag("Player"))
        {
            // Subtract 1 from the score when the enemy collides with the player.
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            // Ensure a ScoreManager instance exists before attempting to update the score.
            if (scoreManager != null)
            {
                // Call the SubtractScore method on the ScoreManager to decrease the score by 1.
                scoreManager.SubtractScore(1);
            }
            
            // Destroy the enemy upon collision with the player.
            Destroy(gameObject);
        }
    }
}



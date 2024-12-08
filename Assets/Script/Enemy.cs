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

    void OnDestroy()
    {
        if (spawner != null)
        {
            spawner.SpawnEnemyWithDelay();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Subtract 1 from the score when the enemy collides with the player.
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            if (scoreManager != null)
            {
                scoreManager.SubtractScore(1);
            }
            
            // Destroy the enemy upon collision with the player.
            Destroy(gameObject);
        }
    }
}



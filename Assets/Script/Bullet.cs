using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3; // Lifetime of the bullet in seconds

    private void Awake()
    {
        Destroy(gameObject, life); // Destroy the bullet after 'life' seconds
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Add 1 to the enemy score when the enemy is hit
            /*ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            if (scoreManager != null)
            {
                scoreManager.AddScore(1); // Add score to the enemy score
            
*/
            // Destroy the enemy and the bullet
            Destroy(collision.gameObject);
        }

        Destroy(gameObject); // Destroy the bullet after any collision
    }
}


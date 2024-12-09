using UnityEngine;

// The 'Bullet' class controls the behavior of a bullet in the game.
public class Bullet : MonoBehaviour
{
    public float life = 3; // Lifetime of the bullet in seconds

    private void Awake()
    {
        Destroy(gameObject, life); // Destroy the bullet after 'life' seconds
    }

    // Called when the bullet collides with another object.
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the object the bullet collided with has the tag "Enemy".
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Destroy the enemy object
            Destroy(collision.gameObject);
        }

        Destroy(gameObject); // Destroy the bullet after any collision
    }
}


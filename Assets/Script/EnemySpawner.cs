using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Assign your enemy prefab here
    public Transform[] spawnPoints; // Array of possible spawn points
    public Transform player; // Reference to the player's transform
    public float fixedSpeed = 5f; // Set a fixed speed for all enemies
    public float spawnDelay = 5f; // Time delay between spawns


    public void SpawnEnemy()
    {
        // Check if the enemy prefab is not assigned or if there are no spawn points specified.
        if (enemyPrefab == null || spawnPoints.Length == 0)
        {
            Debug.LogWarning("Enemy prefab or spawn points not set.");
            return;
        }

        // Choose a random spawn point
        Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

        // Spawn the enemy at the chosen location
        GameObject newEnemy = Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);

        // Assign the spawner and player references to the new enemy
        Enemy enemyScript = newEnemy.GetComponent<Enemy>();
        if (enemyScript != null)
        {
            enemyScript.spawner = this; // Assign the spawner reference
            enemyScript.player = player; // Assign the player reference
            enemyScript.speed = fixedSpeed; // Set the fixed speed
        }

        Debug.Log($"New enemy spawned at: {spawnPoint.position}");
    }
    // Method to start the process of spawning an enemy after a delay.
    public void SpawnEnemyWithDelay()
    {
        // Starts a coroutine that will spawn an enemy after a specified delay.
        StartCoroutine(SpawnEnemyAfterDelay(spawnDelay));
    }
    // Private coroutine to handle delayed enemy spawning.
    private IEnumerator SpawnEnemyAfterDelay(float delay)
    {
        // Waits for the specified amount of time before continuing.
        yield return new WaitForSeconds(delay);
        // Calls the SpawnEnemy method to spawn
        SpawnEnemy();
    }
}


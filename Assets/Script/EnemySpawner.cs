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

    public void SpawnEnemyWithDelay()
    {
        StartCoroutine(SpawnEnemyAfterDelay(spawnDelay));
    }

    private IEnumerator SpawnEnemyAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SpawnEnemy();
    }
}


using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform weaponTip; // Assign the tip of your weapon
    public float range = 100f;
    public float shootForce = 500f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // Left mouse button
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(weaponTip.position, weaponTip.forward, out hit, range))
        {
            Debug.Log("Hit: " + hit.collider.name);

            // Check if the hit object has the Explode script
            Explode explode = hit.collider.GetComponent<Explode>();
            if (explode != null)
            {
                explode.TriggerExplosion();
            }
        }
    }
}

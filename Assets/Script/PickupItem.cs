using UnityEngine;

public class PickupItem : MonoBehaviour
{
    public Transform holdingPosition; // Assign this to the HoldingPosition of your player.
    private bool isPlayerInRange = false;

    void Update()
    {
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.E)) // Press 'E' to pick up
        {
            Pickup();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Ensure the player has the tag "Player"
        {
            isPlayerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
        }
    }

    private void Pickup()
    {
        // Make the item a child of the holding position and reset its transform
        transform.SetParent(holdingPosition);
        transform.localPosition = new Vector3(0.7f,-0.8f, 1f);
        transform.localRotation = Quaternion.Euler(0f, 90f, 90f);

        // Disable the Rigidbody (if any) to make the item static
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.isKinematic = true;
        }
    }
}

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
            // Set the flag to true, indicating the player is within the trigger range.
            isPlayerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the object that exited the trigger has the tag "Player".
        if (other.CompareTag("Player"))
        {
            // Set the flag to false, indicating the player is no longer in the trigger range.
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
        // Check if the Rigidbody component exists (is not null).
        if (rb != null)
        {
            // If a Rigidbody is found, set its isKinematic property to true.
            rb.isKinematic = true;
        }
    }
}

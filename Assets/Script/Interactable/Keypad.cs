using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Keypad' class inherits from the 'Interactable' base class.
public class Keypad : Interactable
{
    //To be assigned in the Unity Inspector without making it publicly accessible.
    [SerializeField]
    //A reference to the door GameObject associated with this keypad.
    private GameObject door;
    // A boolean to track the current state of the door
    private bool doorOpen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Overrides the 'Interact' method from the 'Interactable' base class.
    // Defines the specific interaction behavior for the keypad.
    protected override void Interact()
    {
        doorOpen = !doorOpen;
        // Accesses the Animator component of the door GameObject and updates the "IsOpen" parameter
        door.GetComponent<Animator>().SetBool("IsOpen", doorOpen);
     
    }

}

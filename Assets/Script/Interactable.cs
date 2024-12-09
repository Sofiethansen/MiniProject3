using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//// Define an abstract class called 'Interactable', which will serve as a base class for objects that the player can interact with.
public abstract class  Interactable : MonoBehaviour
{
    //A string to store a message
    public string promotMessage;
    //This is a derived class's specific interaction behavior.
    public void BaseInteract()
    {
        // // Calls the virtual Interact method, which is intended to be overridden by derived classes.
        Interact();
    }


    protected virtual void Interact()
    {

    }
}
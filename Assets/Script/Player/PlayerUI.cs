using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// PlayerUI class manages the user interface for the player, specifically the prompt text display.
public class PlayerUI : MonoBehaviour
{
    [SerializeField]
    // Reference to a TextMeshProUGUI component for displaying prompt messages on the screen.
    private TextMeshProUGUI promptText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Updates the prompt text on the player's UI with a specified message.
    public void UpdateText(string promptMessage)
    {
        // Sets the text of the promptText UI element to the provided string.
        promptText.text = promptMessage;
    }
}

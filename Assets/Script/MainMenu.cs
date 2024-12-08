using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // Replace "GameScene" with the name of your actual game scene
        SceneManager.LoadScene("MainScene");
    }

    public void OpenOptions()
    {
        // Placeholder for options functionality
        Debug.Log("Options menu opened!");
    }

    public void QuitGame()
    {
        Debug.Log("Quit game!");
        Application.Quit();
    }
}


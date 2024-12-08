#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

public class AttachScriptToRubberDucks : MonoBehaviour
{
    [MenuItem("Tools/Attach Script to Rubber Ducks")]
    public static void AttachScript()
    {
        GameObject[] ducks = GameObject.FindGameObjectsWithTag("RubberDuck");

        foreach (GameObject duck in ducks)
        {
            // Ensure the correct script name is used
            if (duck.GetComponent<RubberDuckPickup>() == null)
            {
                duck.AddComponent<RubberDuckPickup>();
            }
        }

        Debug.Log("RubberDuckPickup script attached to all rubber ducks!");
    }
}
#endif


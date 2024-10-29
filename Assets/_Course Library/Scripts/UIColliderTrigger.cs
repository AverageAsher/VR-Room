using UnityEngine;
using TMPro;

public class UIColliderTrigger : MonoBehaviour
{
    public Canvas uiCanvas;  // Assign your UI Canvas here in the Inspector
    public TextMeshProUGUI uiText;  // Assign your TextMeshPro - Text component here

    private void Start()
    {
        uiCanvas.gameObject.SetActive(false);  // Hide the UI at the start
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player entered the trigger
        if (other.CompareTag("Player"))
        {
            uiCanvas.gameObject.SetActive(true);  // Show the UI
            uiText.text = "You can pick up someitems and use them! Try it out!";  // Set your desired text
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the player exited the trigger
        if (other.CompareTag("Player"))
        {
            uiCanvas.gameObject.SetActive(false);  // Hide the UI
        }
    }
}

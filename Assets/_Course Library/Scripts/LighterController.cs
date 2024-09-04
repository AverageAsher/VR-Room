using UnityEngine;
using UnityEngine.InputSystem;  // Add this for the new Input System

public class LighterControllerVR : MonoBehaviour
{
    public GameObject flame;  // Assign the Particle_Flame Prefab here
    public bool isLit = false;

    // Reference to the right-hand trigger
    public InputActionProperty rightHandTrigger;

    void Update()
    {
        // Check if the trigger on the right-hand controller is pressed
        if (rightHandTrigger.action.ReadValue<float>() > 0.5f)  // If the trigger is squeezed
        {
            isLit = !isLit;
            flame.SetActive(isLit);  // Toggle the flame on/off
        }
    }
}
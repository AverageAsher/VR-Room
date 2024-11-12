using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script toggles the visibility of a GameObject.
/// </summary>

public class ToggleVisibility : MonoBehaviour
{
    public GameObject[] labelObjects;

    public void ToggleLabels(bool isActive)
    {
        foreach (var label in labelObjects)
        {
            label.SetActive(isActive);
        }
    }
}

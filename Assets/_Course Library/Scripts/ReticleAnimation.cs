using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float rotationSpeed = 50f; // Adjust this value to change the speed of rotation
    public float minScale = 0.8f; // Minimum scale value
    public float maxScale = 1.2f; // Maximum scale value
    public float scaleSpeed = 0.5f; // Speed of scaling

    private Vector3 initialScale;
    private float currentScale = 1f;
    private bool scalingUp = true;

    void Start()
    {
        initialScale = transform.localScale;
    }

    void Update()
    {
        // Rotation
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);

        // Scaling
        ScaleReticle();
    }

    void ScaleReticle()
    {
        if (scalingUp)
        {
            currentScale += scaleSpeed * Time.deltaTime;
            if (currentScale >= maxScale)
                scalingUp = false;
        }
        else
        {
            currentScale -= scaleSpeed * Time.deltaTime;
            if (currentScale <= minScale)
                scalingUp = true;
        }

        transform.localScale = initialScale * currentScale;
    }
}
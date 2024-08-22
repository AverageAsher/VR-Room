using UnityEngine;

public class BallSound : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        // Get the AudioSource component attached to the ball
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the ball has collided with the ground (you can modify this to suit your setup)
        if (collision.gameObject.CompareTag("Ground"))
        {
            // Play the sound using PlayOneShot
            audioSource.PlayOneShot(audioSource.clip);
        }
    }
}
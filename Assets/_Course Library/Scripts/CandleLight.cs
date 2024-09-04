using UnityEngine;

public class CandleLight : MonoBehaviour
{
    // Particle system for the candle flame
    public GameObject candleFlame;

    // Trigger event when an object with a certain tag enters the collider
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object has the "Lighter" tag
        if (other.CompareTag("Lighter"))
        {
            // Enable or instantiate the flame particle system on the candle
            candleFlame.SetActive(true);
            Debug.Log("Candle has been lit!");
        }
    }
}

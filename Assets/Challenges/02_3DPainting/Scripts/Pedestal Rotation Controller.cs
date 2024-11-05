using UnityEngine;
using UnityEngine.UI;

public class PedestalRotationController : MonoBehaviour
{
    public Slider rotationSlider;
    public Transform pedestal;

    void Start()
    {
        rotationSlider.onValueChanged.AddListener(RotatePedestal);
    }

    void RotatePedestal(float value)
    {
        pedestal.rotation = Quaternion.Euler(0, value, 0);
    }
}

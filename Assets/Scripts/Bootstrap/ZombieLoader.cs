using UnityEngine;
using UnityEngine.UI;

public class ZombieLoader : MonoBehaviour
{
    [Header("UI References")]
    public Slider loadingSlider;
    public RectTransform zombieImage;

    [Header("Movement")]
    public RectTransform startPoint; // Left end of slider
    public RectTransform endPoint;   // Right end of slider

    void Update()
    {
        float progress = loadingSlider.value;
        zombieImage.position = Vector3.Lerp(startPoint.position, endPoint.position, progress);
    }
}

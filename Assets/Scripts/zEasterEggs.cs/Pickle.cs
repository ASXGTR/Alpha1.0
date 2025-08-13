using UnityEngine;

public class Pickle : MonoBehaviour
{
    private readonly string[] crypticLines = new string[]
    {
        "He changed form. Voluntarily.",
        "It wasn’t about escape. It was about principle.",
        "No one asked why. No one dared.",
        "The lab was silent. The brine was not.",
        "He rolled beneath the radar. Literally."
    };

    void Start()
    {
        Debug.Log("🥒 Transformation complete.");
        Whisper();
    }

    private void Whisper()
    {
        int index = Random.Range(0, crypticLines.Length);
        Debug.Log($"🧪 {crypticLines[index]}");
        Debug.Log("🧃 The jar remains sealed. The legend ferments.");
    }
}

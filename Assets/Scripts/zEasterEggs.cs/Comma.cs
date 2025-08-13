using UnityEngine;

public class Comma : MonoBehaviour
{
    private readonly string[] sacredTexts = new string[]
    {
        "One comma to compile them all.",
        "Syntax restored. Flow uninterrupted.",
        "The Smurf blinked. The error vanished.",
        "Comma inserted. Sanity preserved.",
        "Without it, chaos. With it, clarity."
    };

    void Start()
    {
        int index = Random.Range(0, sacredTexts.Length);
        Debug.Log($"🧘‍♂️ {sacredTexts[index]}");
        PerformRitual();
    }

    private void PerformRitual()
    {
        Debug.Log("📜 A comma was placed. No one noticed. Everything worked.");
        Debug.Log("🧠 IDE hints silenced. The vibe continues.");
        Debug.Log("🦆 Duck nodded. Compiler smiled.");
    }
}

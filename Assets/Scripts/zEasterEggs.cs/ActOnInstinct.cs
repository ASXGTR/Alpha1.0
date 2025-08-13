using UnityEngine;

public class ActOnInstinct : MonoBehaviour
{
    private readonly string[] transmission = new string[]
    {
        "We are going to have to act",
        "If we want to live in a different world",
        "We are going to have to act",
        "There is a very unstable situation on the ground",
        "That is unfolding very quickly",
        "Move towards more ideas that will actually help, uh",
        "Bring this thing to an end",
        "We are going to have to act",
        "We are going to have to act",
        "There is a very unstable situation on the ground",
        "That is unfolding very quickly"
    };

    void Start()
    {
        Debug.Log("📡 Transmission received: ACT ON INSTINCT");
        Broadcast();
    }

    private void Broadcast()
    {
        foreach (string line in transmission)
        {
            Debug.Log($"🧠 {line}");
        }

        Debug.Log("📡 End of transmission. Interpret as needed.");
    }
}

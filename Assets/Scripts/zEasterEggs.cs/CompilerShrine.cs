using UnityEngine;

public class CompilerShrine : MonoBehaviour
{
    [SerializeField] private GameObject offering;
    [SerializeField] private bool compilerIsPleased;

    void Awake()
    {
        compilerIsPleased = UnityEngine.Random.value > 0.2f;
        if (compilerIsPleased)
        {
            Debug.Log("🛐 The compiler accepts your offering.");
        }
        else
        {
            Debug.LogWarning("💀 The compiler demands more.");
        }
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class Bootloader : MonoBehaviour
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void Initialize()
    {
        Debug.Log("Bootloader: Backend initialization started.");

        // Future backend setup goes here

        Debug.Log("Bootloader: Initialization complete. Loading TitleScene...");

        SceneManager.LoadScene("TitleScene"); // Make sure this matches your scene name exactly
    }
}

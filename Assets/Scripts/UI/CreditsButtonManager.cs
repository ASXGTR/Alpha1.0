using UnityEngine;
using UnityEngine.UI;
using UI; // Namespace for CreditsUIManager

public class CreditsButtonManager : MonoBehaviour
{
    [Header("UI References")]
    public Button buttonCreditsOpen;
    public Button buttonCreditsClosed;

    public GameObject titleCanvas;
    public CreditsUIManager creditsUIManager;

    void Start()
    {
        buttonCreditsOpen.onClick.AddListener(ShowCreditsPanel);
        buttonCreditsClosed.onClick.AddListener(HideCreditsPanel);

        // Ensure credits panel is hidden at start
        creditsUIManager.HideCredits();
    }

    void ShowCreditsPanel()
    {
        creditsUIManager.ShowCredits();
        if (titleCanvas != null) titleCanvas.SetActive(false);
    }

    void HideCreditsPanel()
    {
        creditsUIManager.HideCredits();
        if (titleCanvas != null) titleCanvas.SetActive(true);
    }
}

using UnityEngine;

namespace UI
{
    public class CreditsUIManager : MonoBehaviour
    {
        [Header("Assign via Inspector")]
        public GameObject creditsCanvas;

        public void ShowCredits()
        {
            if (creditsCanvas != null)
            {
                creditsCanvas.SetActive(true);
            }
        }

        public void HideCredits()
        {
            if (creditsCanvas != null)
            {
                creditsCanvas.SetActive(false);
            }
        }
    }
}

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Bootstrap
{
    public class SimulatedLoadingManager : MonoBehaviour
    {
        [Header("UI References")]
        public Slider loadingBar;
        public Text loadingText;

        [Header("Simulation Settings")]
        public float simulatedDuration = 5f;

        private float timer = 0f;

        void Update()
        {
            timer += Time.deltaTime;
            float progress = Mathf.Clamp01(timer / simulatedDuration);
            loadingBar.value = progress;
            loadingText.text = $"Loading... {Mathf.RoundToInt(progress * 100)}%";

            if (progress >= 1f)
            {
                SceneManager.LoadScene("TitleScreen");
            }
        }
    }
}

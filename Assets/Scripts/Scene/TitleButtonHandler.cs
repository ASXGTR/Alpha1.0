using UnityEngine;
using UnityEngine.UI;
using Audio;

namespace Project.Scene
{
    /// <summary>
    /// Handles the Start button on the Title Screen.
    /// Located at: Assets/Scripts/Scene/TitleButtonHandler.cs
    /// </summary>
    public class TitleButtonHandler : MonoBehaviour
    {
        [Header("Assign the Start Button via Inspector")]
        [Tooltip("Button that triggers transition to MainScene.")]
        public Button startButton;

        private const string targetSceneName = "MainScene";

        private void Start()
        {
            if (startButton != null)
            {
                startButton.onClick.AddListener(OnStartButtonPressed);
            }
            else
            {
                Debug.LogError("[TitleButtonHandler] Start button not assigned in inspector.");
            }
        }

        private void OnStartButtonPressed()
        {
            Debug.Log($"[TitleButtonHandler] Start button pressed. Transitioning to '{targetSceneName}'...");

            if (AudioManager.Instance != null)
            {
                AudioManager.Instance.FadeOutMusic();
            }

            SceneTransitionManager.Instance.LoadScene(targetSceneName);
        }
    }
}

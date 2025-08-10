using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

namespace Project.Scene
{
    /// <summary>
    /// Centralized manager for handling scene transitions across the game.
    /// Supports additive loading, loading screens, and future extensibility.
    /// Located at: Assets/Scripts/Scene/SceneTransitionManager.cs
    /// </summary>
    public class SceneTransitionManager : MonoBehaviour
    {
        public static SceneTransitionManager Instance { get; private set; }

        [Header("Optional: Loading Screen Prefab")]
        [Tooltip("Assign a loading screen prefab to display during transitions.")]
        public GameObject loadingScreenPrefab;

        private GameObject loadingScreenInstance;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Debug.LogWarning("[SceneTransitionManager] Duplicate instance detected. Destroying self.");
                Destroy(gameObject);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        /// <summary>
        /// Loads a scene by name. Optionally shows a loading screen.
        /// </summary>
        public void LoadScene(string sceneName, bool useLoadingScreen = true)
        {
            StartCoroutine(LoadSceneRoutine(sceneName, useLoadingScreen));
        }

        /// <summary>
        /// Loads a scene additively (e.g. camp, cutscene overlay).
        /// </summary>
        public void LoadSceneAdditive(string sceneName)
        {
            SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
        }

        /// <summary>
        /// Unloads an additive scene.
        /// </summary>
        public void UnloadScene(string sceneName)
        {
            SceneManager.UnloadSceneAsync(sceneName);
        }

        private IEnumerator LoadSceneRoutine(string sceneName, bool useLoadingScreen)
        {
            if (useLoadingScreen && loadingScreenPrefab != null)
            {
                loadingScreenInstance = Instantiate(loadingScreenPrefab);
            }

            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);
            asyncLoad.allowSceneActivation = false;

            while (asyncLoad.progress < 0.9f)
            {
                yield return null;
            }

            // Optional delay for fade or animation
            yield return new WaitForSeconds(0.5f);

            asyncLoad.allowSceneActivation = true;

            while (!asyncLoad.isDone)
            {
                yield return null;
            }

            if (loadingScreenInstance != null)
            {
                Destroy(loadingScreenInstance);
            }
        }
    }
}

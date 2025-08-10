using UnityEngine;
using UnityEngine.SceneManagement;

namespace Bootstrap
{
    public class BootstrapManager : MonoBehaviour
    {
        [SerializeField] private string titleSceneName = "TitleScreen";

        void Start()
        {
            StartCoroutine(InitializeApp());
        }

        private System.Collections.IEnumerator InitializeApp()
        {
            // Simulate loading time or async setup
            yield return new WaitForSeconds(2f);

            // TODO: Load remote configs, initialize managers, etc.

            // Transition to title screen
            SceneManager.LoadScene(titleSceneName);
        }
    }
}

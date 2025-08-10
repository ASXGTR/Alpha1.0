using UnityEngine;
using UnityEngine.UI;

namespace Bootstrap
{
    public class LoadingScreenController : MonoBehaviour
    {
        [SerializeField] private CanvasGroup canvasGroup;
        [SerializeField] private Image progressBar;

        private void Awake()
        {
            if (canvasGroup != null)
                canvasGroup.alpha = 1f;

            if (progressBar != null)
                progressBar.fillAmount = 0f;
        }

        public void SetProgress(float value)
        {
            if (progressBar != null)
                progressBar.fillAmount = Mathf.Clamp01(value);
        }

        public void FadeOut(float duration = 1f)
        {
            if (canvasGroup != null)
                StartCoroutine(FadeCanvas(duration));
        }

        private System.Collections.IEnumerator FadeCanvas(float duration)
        {
            float elapsed = 0f;
            while (elapsed < duration)
            {
                canvasGroup.alpha = Mathf.Lerp(1f, 0f, elapsed / duration);
                elapsed += Time.deltaTime;
                yield return null;
            }
            canvasGroup.alpha = 0f;
        }
    }
}

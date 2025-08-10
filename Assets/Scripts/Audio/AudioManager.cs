using UnityEngine;
using System.Collections;

namespace Audio
{
    /// <summary>
    /// Centralized audio manager for music and SFX.
    /// Lives in Audio/Scripts. Controls playback and persistence.
    /// </summary>
    public class AudioManager : MonoBehaviour
    {
        public static AudioManager Instance;

        [Header("Music")]
        public AudioClip titleTheme;
        private AudioSource musicSource;

        private bool hasFadedOut = false;
        private float fadeDuration = 8f;

        void Awake()
        {
            // Singleton pattern
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(gameObject);

            // Setup AudioSource
            musicSource = gameObject.AddComponent<AudioSource>();
            musicSource.loop = true;
            musicSource.playOnAwake = false;
            musicSource.volume = 0.7f;

            PlayTitleTheme();
        }

        public void PlayTitleTheme()
        {
            if (titleTheme != null && !hasFadedOut)
            {
                musicSource.clip = titleTheme;
                musicSource.loop = true;
                musicSource.Play();
            }
        }

        public void StopMusic()
        {
            musicSource.Stop();
        }

        public void SetVolume(float volume)
        {
            musicSource.volume = Mathf.Clamp01(volume);
        }

        public void FadeOutMusic()
        {
            if (!hasFadedOut)
            {
                StartCoroutine(FadeOutRoutine());
            }
        }

        private IEnumerator FadeOutRoutine()
        {
            hasFadedOut = true;
            float startVolume = musicSource.volume;

            // Disable looping so it doesn't restart mid-fade
            musicSource.loop = false;

            for (float t = 0; t < fadeDuration; t += Time.deltaTime)
            {
                musicSource.volume = Mathf.Lerp(startVolume, 0f, t / fadeDuration);
                yield return null;
            }

            musicSource.volume = 0f;
            musicSource.Stop();
        }
    }
}

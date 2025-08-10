using UnityEngine;
using UnityEngine.UI;

public class SimulatedLoader : MonoBehaviour
{
    public Slider loadingBar;
    public Text loadingText;
    public float loadDuration = 3f; // seconds

    private float timer = 0f;

    void Start()
    {
        timer = 0f;
        loadingBar.value = 0f;
        loadingText.text = "Loading...";
    }

    void Update()
    {
        if (timer < loadDuration)
        {
            timer += Time.deltaTime;
            loadingBar.value = timer / loadDuration;
        }
        else
        {
            loadingText.text = "Load Complete!";
        }
    }
}


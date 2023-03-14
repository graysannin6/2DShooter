using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float totalTime = 600f; // Total time in seconds (10 minutes)
    private float elapsedTime = 0f; // Elapsed time in seconds
    public Text timerText; // Text component to display the remaining time

    void Update()
    {
        elapsedTime += Time.deltaTime; // Increase the elapsed time by the delta time
        float remainingTime = totalTime - elapsedTime; // Calculate the remaining time
        int minutes = Mathf.FloorToInt(remainingTime / 60f); // Calculate the number of minutes
        int seconds = Mathf.FloorToInt(remainingTime % 60f); // Calculate the number of seconds
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds); // Update the text component

        if (remainingTime <= 0f)
        {
            // Timer has expired, do something here
        }
    }
}



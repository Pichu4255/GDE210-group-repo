using UnityEngine;
using UnityEngine.UI;
using TMPro; // TextMeshPro

public class CountDown : MonoBehaviour
{
    public float timeRemaining = 10f; // The time to count down from
    public bool timerIsRunning = false; //initialize as not running
    public TextMeshProUGUI timeText; // Assign in the inspector

    private void Start()
    {
        // Start the timer when scene loads
        timerIsRunning = true;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime; // Subtract time passed
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Over");
                timeRemaining = 0;
                timerIsRunning = false; // Stop the timer
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        // time ends at 0
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60); // Calculate minutes
        float seconds = Mathf.FloorToInt(timeToDisplay % 60); // Calculate seconds

        // Format the time
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}

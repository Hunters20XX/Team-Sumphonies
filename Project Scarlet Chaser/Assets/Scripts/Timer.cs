using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 0;
    public bool timerIsRunning = false;
    public TMP_Text timeText;
    public GameObject results;
    public TMP_Text hitsText;
    public int hits;
    public int totalNotes;


    void Start()
    {
        timerIsRunning = true;
        hitsText.text = "Total Hits: " + hits.ToString() + " / " + totalNotes;
        results.SetActive(false);
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 1)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else if (timeRemaining <= 1)
            {
                results.SetActive(true);
                timerIsRunning = false;
                Time.timeScale = 0;
                hitsText.text = "Total Hits: " + hits.ToString() + " / " + totalNotes;
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = "Time: " + string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
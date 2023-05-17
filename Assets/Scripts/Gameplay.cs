using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using TMPro;

public class Gameplay : MonoBehaviour
{
    public float timeRemaining = 0;
    public bool timerIsRunning = false;
    public TMP_Text timeText;
    public GameObject results;
    public GameObject pauseText;
    public TMP_Text hitsText;
    public TMP_Text scoreText;
    
    public TMP_Text rankhitText;
    public TMP_Text rankscoreText;
    
    public int hits;
    public int score;
    public int totalNotes;
    

    public bool pause = false;
    public bool end = false;
    public static float unscaledTime;

    public bool rankF;
    public bool rankD;
    public bool rankC;
    public bool rankB;
    public bool rankA;
    public bool rankS;


    void Start()
    {

        timerIsRunning = true;
        hitsText.text = "Total Hits: " + hits.ToString() + " / " + totalNotes + " = ";
        scoreText.text = "Total Score: " + score.ToString();
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
                end = true;
                timerIsRunning = false;
                Time.timeScale = 0;
                hitsText.text = "Total Hits: " + hits.ToString() + " / " + totalNotes;
                scoreText.text = "Total Score: " + score.ToString();
            }

            if (rankD == false)
            {
                rankscoreText.text = "F";
            }

            if (rankD == true)
            {
                rankscoreText.text = "D";
            }

            if (rankC == true)
            {
                rankscoreText.text = "C";
            }

            if (rankB == true)
            {
                rankscoreText.text = "B";
            }

            if (rankA == true)
            {
                rankscoreText.text = "A";
            }

            if (rankS == true)
            {
                rankscoreText.text = "S";
            }

            if(score <= 600)
            {
                rankF = true;
            }

            if(score > 600 && score <= 1200)
            {
                rankF = false;
                rankD = true;
            }

            if(score > 1200 && score <= 1800)
            {
                rankD = false;
                rankC = true;
            }

            if(score > 1800 && score <= 2400)
            {
                rankC = false;
                rankB = true;
            }

            if(score > 2400 && score <= 3000)
            {
                rankB = false;
                rankA = true;
            }

            if(score > 3000)
            {
                rankA = false;
                rankS = true;
            }
        }


        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            pause = !pause;

            //more code here
        }
        if (pause == true && end == false)
        {
            Time.timeScale = 0;
            pauseText.SetActive(true);
        }
        else if (pause == false && end == false)
        {
            Time.timeScale = 1;
            pauseText.SetActive(false);
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = "Time: " + string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
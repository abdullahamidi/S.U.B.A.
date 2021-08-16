using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float timeRemaining = 80;
    public static bool timerIsRunning = true;
    public Text timeText;
    public static int agacCount = 13;
    public Canvas ekranlar;


    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else if (timeRemaining <= 0 && agacCount > 7)
            {
                timerIsRunning = false;

                Time.timeScale = 0;
                transform.GetComponent<Movement>().enabled = false;
                transform.Find("Sounds").gameObject.SetActive(false);
            ekranlar.transform.Find("WinPanel").gameObject.SetActive(true);
            }
            else
            {
                //timeRemaining = 0;
                timerIsRunning = false;

                Time.timeScale = 0;
                transform.GetComponent<Movement>().enabled = false;
                transform.Find("Sounds").gameObject.SetActive(false);

                ekranlar.transform.Find("LosePanel").gameObject.SetActive(true);

            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
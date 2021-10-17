using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Text timerText;
    //Needs to set to 65 to start at 60 for some reason??? 
    float timeRemaining;
    bool timerIsRunning = false;

    void Start()
    {
        timeRemaining = 60f;
        timerIsRunning = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                //Debug.Log(Time.unscaledDeltaTime);
                timeRemaining -= Time.unscaledDeltaTime;
                string seconds = (timeRemaining % 60).ToString("f2");
                timerText.text = seconds;
            }
            else
            {
                timeRemaining = 0;
                timerText.text = "0";
                timerIsRunning = false;
            }
        }
    }
}

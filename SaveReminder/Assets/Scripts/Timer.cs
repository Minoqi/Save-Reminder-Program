using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{
    //Variables
    public Text countdownTimerText;
    public float secondsLeft = 3610; //3600 = 1 hour
    public bool timerOn = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CalculateTime();
    }

    //Calculates Time
    void CalculateTime()
    {
        if (timerOn)
        {
            secondsLeft -= Time.deltaTime;
            TimeSpan timeLeft = TimeSpan.FromSeconds(secondsLeft);
            countdownTimerText.text = timeLeft.ToString(@"hh\:mm\:ss");
        }
    }
}

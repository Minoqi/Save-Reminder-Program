using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    //Variables
    private string numbersTogether;
    public float totalTime = 0, timeBeforeConversion;
    public GameObject hourLeft, hourRight, minuteLeft, minuteRight, secondLeft, secondRight; //Timer Buttons
    public Text countdownTimerText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateText();
    }

    //Get Value for Each Section & Update Text
    void UpdateText()
    {
        countdownTimerText.text = hourLeft.GetComponent<GetTime>().value.ToString() + hourRight.GetComponent<GetTime>().value.ToString() + ":" + minuteLeft.GetComponent<GetTime>().value.ToString() + minuteRight.GetComponent<GetTime>().value.ToString() + ":" + secondLeft.GetComponent<GetTime>().value.ToString() + secondRight.GetComponent<GetTime>().value.ToString();
    }

    //Calculate Total Time
    public void CalculateTotalTime()
    {
        //Hours
        numbersTogether = hourLeft.GetComponent<GetTime>().value.ToString() + hourRight.GetComponent<GetTime>().value.ToString(); //Combine Hour Values to Give Whole Hour (First Value = 1, Second = 2, 1 + 2 = 12)
        timeBeforeConversion = (float)int.Parse(numbersTogether);
        totalTime += (timeBeforeConversion * 3600f); //Hours, Convert to Seconds
        numbersTogether = "";

        //Minutes
        numbersTogether = minuteLeft.GetComponent<GetTime>().value.ToString() + minuteRight.GetComponent<GetTime>().value.ToString();
        timeBeforeConversion = (float)int.Parse(numbersTogether);
        totalTime += (timeBeforeConversion * 60f); //Minutes, Convert to Seconds
        numbersTogether = "";

        //Seconds
        numbersTogether = secondLeft.GetComponent<GetTime>().value.ToString() + secondRight.GetComponent<GetTime>().value.ToString();
        timeBeforeConversion = (float)int.Parse(numbersTogether);
        totalTime += timeBeforeConversion; //Seconds
    }

    //Set Time for Timer & Start it
    public void StartTimerFunction()
    {
        gameObject.GetComponent<Timer>().secondsLeft = totalTime;
        gameObject.GetComponent<Timer>().timerOn = true;
    }
}

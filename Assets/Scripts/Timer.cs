using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float totalSecondsValue = 180;
    public TMP_Text timeText;
    public bool pauseBool = false;

    void Update()
    {
        if (pauseBool != true)
        {
            TimerDecrease();
        }
        else
        {
            
        }
        DisplayTime(totalSecondsValue);

    }

    private void TimerDecrease()
    {
        if (totalSecondsValue > 0)
        {
            totalSecondsValue -= Time.deltaTime;
        }
        else
        {
            totalSecondsValue = 0;
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }

    public void StopTimer()
    {
        pauseBool = true;
    }
}

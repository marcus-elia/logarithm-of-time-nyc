using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public static float timeRemaining = 60f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timeRemaining -= Time.deltaTime;
        Debug.Log(timeRemaining);
    }

    public static void addTime(float amount)
    {
        timeRemaining += amount;
    }

    public static string timeText()
    {
        if (timeRemaining < 60)
        {
            return ((int)timeRemaining).ToString() + "s";
        }
        else
        {
            int mins = (int)(timeRemaining / 60);
            return mins.ToString() + "m" + ((int)timeRemaining) % 60 + "s";
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public static float timeRemaining = 60f;
    public static Queue<float> timesToAdd = new Queue<float>();
    public static int timeUnitsPlayerHas = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (timesToAdd.Count == 0)
        {
            timeRemaining -= Time.deltaTime;
        } 
        else
        {
            timeRemaining += timesToAdd.Dequeue();
        }
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

    public static void deliverTimeUnits()
    {
        while (timeUnitsPlayerHas > 0)
        {
            timeUnitsPlayerHas--;
            if (timesToAdd.Count == 0)
            {
                timesToAdd.Enqueue(30);
            }
            else
            {
                timesToAdd.Enqueue(timesToAdd.Peek() * 0.67f);
            }
        }
    }
}

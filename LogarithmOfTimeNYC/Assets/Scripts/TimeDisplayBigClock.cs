using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeDisplayBigClock : MonoBehaviour
{
    public TextMeshPro timeText1;
    public TextMeshPro timeText2;
    public TextMeshPro timeText3;
    public TextMeshPro timeText4;
    public TextMeshPro timeText5;
    public TextMeshPro timeText6;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string t = TimeManager.timeText();
        timeText1.text = t;
        timeText2.text = t;
        timeText3.text = t;
        timeText4.text = t;
        timeText5.text = t;
        timeText6.text = t;
    }
}

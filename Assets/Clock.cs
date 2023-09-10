using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clock : MonoBehaviour
{
    [SerializeField]
    Transform hoursPivot;

    [SerializeField]
    Transform minutesPivot;

    [SerializeField]
    Transform secondsPivot;

    //const float hourToDegrees = -6f;

    private void Update()
    {
        //Debug.Log(DateTime.Now.Hour*-30);
        //Debug.Log(DateTime.Now.Hour + "  " + DateTime.Now.Minute + "  " + DateTime.Now.Second);
        //Debug.Log((float)time.TotalHours + "   " + (float)time.TotalMinutes + "  " + (float)time.TotalSeconds);
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursPivot.localEulerAngles = new Vector3(0, 0, -30f * (float)time.TotalHours);
        minutesPivot.localEulerAngles = new Vector3(0,0,-6f* (float)time.TotalMinutes);
        secondsPivot.localEulerAngles = new Vector3(0,0,-6f* DateTime.Now.Second);
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Timer : MonoBehaviour
{
    [SerializeField]
    GameObject timerstart;
    float timertime = 0;
    bool timerRun = true;
    public TMP_Text timertext;
    Countdown cd;

    private void Start()
    {
        cd = timerstart.GetComponent<Countdown>();
    }

    void Update()
    {
        if (cd.startrace == true)
        {
            if (timerRun == true)
            {
                if (timertime >= 0)
                {
                    displaytime(timertime);
                    timertime += Time.deltaTime;
                }
            }
        }
    }
    void displaytime(float timercurrent)
    {
        timercurrent += 1;
        float minutes = Mathf.FloorToInt(timercurrent / 60);
        float seconds = Mathf.FloorToInt(timercurrent % 60);
        float milliseconds = (timercurrent % 1) * 1000;
        timertext.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
    }
}

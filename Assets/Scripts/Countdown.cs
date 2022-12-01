using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Countdown : MonoBehaviour
{
    public float timertime = 4.5f;
    bool timerRun = true;
    public bool startrace = false;

    [SerializeField]
    GameObject cd1;
    [SerializeField]
    GameObject cd2;
    [SerializeField]
    GameObject cd3;
    void Update()
    {
        if (timerRun == true)
        {
            if (timertime >= 0)
            {
                timertime += Time.deltaTime;
            }
            /*if(!Mathf.Approximately(timertime, 5))
            {
                FindObjectOfType<AudioManager>().Play("countdownBeeb");
            }
            if (!Mathf.Approximately(timertime, 8))
            {
                FindObjectOfType<AudioManager>().Play("countdownBeeb");
            }
            if (!Mathf.Approximately(timertime, 9))
            {
                FindObjectOfType<AudioManager>().Play("countdownBeeb");
            }
            if (!Mathf.Approximately(timertime, 10))
            {
                FindObjectOfType<AudioManager>().Play("countdownBeeb");
            }
            if (!Mathf.Approximately(timertime, 11))
            {
                FindObjectOfType<AudioManager>().Play("startRaceBeeb");
            }*/

            if (timertime >= 8 &&timertime <= 9)
            {
                cd1.SetActive(true);
                cd2.SetActive(false);
                cd3.SetActive(false);
            }
            if (timertime >= 9 && timertime <= 10)
            {
                cd1.SetActive(false);
                cd2.SetActive(true);
                cd3.SetActive(false);
            }
            if (timertime >= 10 && timertime <= 11)
            {
                cd1.SetActive(false);
                cd2.SetActive(false);
                cd3.SetActive(true);
            }
            if (timertime >= 11)
            {
                timerRun = false;
                cd3.SetActive(false);
                startrace = true;
            }
        }
    }
    //void displaytime(float timercurrent)
   // {
       // timercurrent += 1;
        //float minutes = Mathf.FloorToInt(timercurrent / 60);
        //float seconds = Mathf.FloorToInt(timercurrent % 60);
        //float milliseconds = (timercurrent % 1) * 1000;
        //timertext.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
    //}
}

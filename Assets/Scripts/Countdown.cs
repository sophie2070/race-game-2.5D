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
    [SerializeField]
    GameObject start;
    [SerializeField]
    GameObject prestart;
    [SerializeField]
    GameObject theme;
    void Update()
    {
        if (timerRun == true)
        {
            if (timertime >= 0)
            {
                timertime += Time.deltaTime;
            }
            if(timertime >= 5.5f && timertime <= 8)
            {
                prestart.SetActive(true);
            }

            if (timertime >= 8 &&timertime <= 9)
            {
                prestart.SetActive(false);
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
            if (timertime >= 11 && timertime <= 12)
            {
                
                cd3.SetActive(false);
                start.SetActive(true);
                startrace = true;
                theme.SetActive(true);
            }
            if (timertime >= 12 && timertime <= 13)
            { 
                start.SetActive(false);
                timerRun = false;
            }
        }
    }
}

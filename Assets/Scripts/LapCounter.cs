using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapCounter : MonoBehaviour
{
    [SerializeField]
    GameObject lap1;
    [SerializeField]
    GameObject lap2;
    [SerializeField]
    GameObject lap3;

    WaypointDetection WaypointDetection;
    private void Update()
    {
        if (WaypointDetection.currentLap == 1)
        {
            lap1.SetActive(true);
            lap2.SetActive(false);
            lap3.SetActive(false);
        }
        if (WaypointDetection.currentLap == 2)
        {
            lap1.SetActive(false);
            lap2.SetActive(true);
            lap3.SetActive(false);
        }
        if (WaypointDetection.currentLap == 3)
        {
            lap1.SetActive(false);
            lap2.SetActive(false);
            lap3.SetActive(true);
        }
    }

}

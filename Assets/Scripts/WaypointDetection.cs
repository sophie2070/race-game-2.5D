using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WaypointDetection : MonoBehaviour
{
    int currentWaypoint = 0;
    int currentLap = 1;
    

    
    private void OnTriggerEnter()
    {
        if (gameObject.CompareTag("Waypoint"))
        {
            currentWaypoint++;
            Debug.Log("waypointhit");
        }
    }

    private void Update()
    {
        if (currentWaypoint >= 12)
        {
            currentWaypoint = 0;
            currentLap++;
        }
        if (currentLap >= 3)
        {

        }
    }
}

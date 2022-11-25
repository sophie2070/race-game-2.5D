using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WaypointDetection : MonoBehaviour
{
    int currentWaypoint = 0;
    int currentLap = 1;
    [SerializeField]
    GameObject finish;


    private void OnTriggerEnter(Collider waypointhit)
    {
        if (waypointhit.gameObject.CompareTag("Waypoint"))
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
        if (currentWaypoint >= 35)
        {
            finish.SetActive(enabled);
        }
    }
}

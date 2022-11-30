using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WaypointDetection : MonoBehaviour
{
    public int currentWaypoint = 0;
    public int currentLap = 1;
    [SerializeField]
    GameObject finish;

    


    private void OnTriggerEnter(Collider waypointhit)
    {
        if (waypointhit.gameObject.CompareTag("Waypoint"))
        {
            currentWaypoint++;
            Debug.Log("waypointhit");
            FindObjectOfType<AudioManager>().Play("NewLap");
        }
        if (waypointhit.gameObject.CompareTag("Finish"))
        {
            Debug.Log("Finished");
            FindObjectOfType<AudioManager>().Play("Finished");
        }
    }

    private void Update()
    {
        if (currentWaypoint >= 12)
        {
            currentLap = 2;
        }
        if (currentWaypoint >= 24)
        {
            currentLap = 3;
        }
        if (currentWaypoint >= 35 && currentLap >= 3)
        {
            finish.SetActive(enabled);
            
        }
    }
}

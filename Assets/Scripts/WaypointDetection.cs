using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WaypointDetection : MonoBehaviour
{
    public int currentWaypoint = 0;
    public int currentLap = 1;
    public int rainbowRing = 0;
    [SerializeField]
    GameObject finish;
    [SerializeField]
    GameObject newlap;




    private void OnTriggerEnter(Collider waypointhit)
    {
        if (waypointhit.gameObject.CompareTag("Waypoint"))
        {
            currentWaypoint++;
        }
        if (waypointhit.gameObject.CompareTag("NewLap"))
        {
            FindObjectOfType<AudioManager>().Play("NewLap");
        }
        if (waypointhit.gameObject.CompareTag("Finish"))
        {
            FindObjectOfType<AudioManager>().Play("Finished");
        }
        if (waypointhit.gameObject.CompareTag("RainbowLoop"))
        {
            FindObjectOfType<AudioManager>().Play("RainbowLoop1");
        }
        if (waypointhit.gameObject.CompareTag("RainbowLoop2"))
        {
            FindObjectOfType<AudioManager>().Play("RainbowLoop2");
        }
        if (waypointhit.gameObject.CompareTag("RainbowLoop"))
        {
            FindObjectOfType<AudioManager>().Play("RainbowLoop3");
        }
    }

    private void Update()
    {
        if (currentWaypoint == 17)
        {
            newlap.SetActive(true);
        }
        if (currentWaypoint >= 19)
        {
            currentLap = 2;
        }
        if (currentWaypoint >= 36)
        {
            currentLap = 3;
        }
        if (currentWaypoint >= 50 && currentLap >= 3)
        {
            finish.SetActive(true);
            newlap.SetActive(false);
        }
        if (currentWaypoint == 60)
        {
            finish.SetActive(false);
        }
    }
}

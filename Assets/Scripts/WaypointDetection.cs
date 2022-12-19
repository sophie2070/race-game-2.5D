using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WaypointDetection : MonoBehaviour
{
    public int currentWaypoint = 0;
    public int currentLap = 1;
    //public int rainbowRing = 0;
    public int newlaps = 0;

    [SerializeField]
    GameObject finish;
    [SerializeField]
    GameObject newlap;
   // [SerializeField]
    //GameObject am;
    [SerializeField]
    Controller controller;

    //AudioManager AudioManager;

    private void Awake()
    {
        //AudioManager = am.GetComponent<AudioManager>();
        controller = controller.GetComponent<Controller>();
    }

    private void OnTriggerEnter(Collider waypointhit)
    {
        if (waypointhit.gameObject.CompareTag("Waypoint"))
        {
            currentWaypoint++;
        }
        if (waypointhit.gameObject.CompareTag("NewLap"))
        {
            //AudioManager.Play("NewLap");
            newlaps++;
        }
        /*if (waypointhit.gameObject.CompareTag("Finish"))
        {
            AudioManager.Play("Finished");
        }
        if (waypointhit.gameObject.CompareTag("RainbowLoop"))
        {
            AudioManager.Play("RainbowLoop1");
        }
        if (waypointhit.gameObject.CompareTag("RainbowLoop2"))
        {
            AudioManager.Play("RainbowLoop2");
        }
        if (waypointhit.gameObject.CompareTag("RainbowLoop"))
        {
            AudioManager.Play("RainbowLoop3");
        }*/
        if (waypointhit.gameObject.CompareTag("SpeedPad"))
        {
            controller.SpeedBoost();
        }
    }

    private void Update()
    {
        if (currentWaypoint == 25)
        {
            newlap.SetActive(true);
        }
        if (currentWaypoint == 29 && newlaps == 1 && currentLap == 1)
        {
            currentLap = 2;
            currentWaypoint = 0;
        }
        if (currentWaypoint >= 29 && currentLap == 2 && newlaps == 2)
        {
            currentLap = 3;
            currentWaypoint = 0;
        }
        if (currentWaypoint >= 29 && currentLap >= 3 && newlaps == 3)
        {
            finish.SetActive(true);
            newlap.SetActive(false);
            currentLap = 4;
        }
        if (currentWaypoint == 5 && currentLap == 4)
        {
            finish.SetActive(false);
        }
        if(currentWaypoint == 29 && currentLap == 4)
        {
            currentWaypoint = 0;
        }
    }
}

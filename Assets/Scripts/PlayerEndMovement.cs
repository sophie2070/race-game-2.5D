using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEndMovement : MonoBehaviour
{
    Controller controller;
    WaypointDetection waypointDetection;
    Countdown countdown;
    EndScreen endScreen;


    [SerializeField]
    GameObject waypoint1;
    [SerializeField]
    GameObject waypoint2;
    [SerializeField]
    GameObject waypoint3;
    [SerializeField]
    GameObject waypoint4;
    [SerializeField]
    GameObject waypoint5;
    [SerializeField]
    GameObject waypoint6;
    [SerializeField]
    GameObject waypoint7;
    [SerializeField]
    GameObject waypoint8;
    [SerializeField]
    GameObject waypoint9;
    [SerializeField]
    GameObject waypoint10;
    [SerializeField]
    GameObject waypoint11;
    [SerializeField]
    GameObject waypoint12;
    [SerializeField]
    GameObject waypoint13;
    [SerializeField]
    GameObject waypoint14;
    [SerializeField]
    GameObject waypoint15;
    [SerializeField]
    GameObject waypoint16;
    [SerializeField]
    GameObject waypoint17;
    [SerializeField]
    GameObject timer;
    [SerializeField]
    GameObject endscreenie;




    private void Awake()
    {
        controller = GetComponent<Controller>();
        countdown = timer.GetComponent<Countdown>();
        waypointDetection = GetComponent<WaypointDetection>();
        endScreen = endscreenie.GetComponent<EndScreen>();
    }

    private void Update()
    {
        if (countdown.startrace == true)
        {
            if (endScreen.finished == true)
            {
                controller.ChangeSpeed(1);

                switch (waypointDetection.currentWaypoint)
                {
                    case 1:
                        controller.FacingWaypoint(waypoint1.transform);
                        break;
                    case 2:
                        controller.FacingWaypoint(waypoint2.transform);
                        break;
                    case 3:
                        controller.FacingWaypoint(waypoint3.transform);
                        break;
                    case 4:
                        controller.FacingWaypoint(waypoint4.transform);
                        break;
                    case 5:
                        controller.FacingWaypoint(waypoint5.transform);
                        break;
                    case 6:
                        controller.FacingWaypoint(waypoint6.transform);
                        break;
                    case 7:
                        controller.FacingWaypoint(waypoint7.transform);
                        break;
                    case 8:
                        controller.FacingWaypoint(waypoint8.transform);
                        break;
                    case 9:
                        controller.FacingWaypoint(waypoint9.transform);
                        break;
                    case 10:
                        controller.FacingWaypoint(waypoint10.transform);
                        break;
                    case 11:
                        controller.FacingWaypoint(waypoint11.transform);
                        break;
                    case 12:
                        controller.FacingWaypoint(waypoint12.transform);
                        break;
                    case 13:
                        controller.FacingWaypoint(waypoint13.transform);
                        break;
                    case 14:
                        controller.FacingWaypoint(waypoint14.transform);
                        break;
                    case 15:
                        controller.FacingWaypoint(waypoint15.transform);
                        break;
                    case 16:
                        controller.FacingWaypoint(waypoint16.transform);
                        break;
                    case 17:
                        controller.FacingWaypoint(waypoint17.transform);
                        break;
                    default:
                        Debug.Log("no waypoint");
                        break;
                }
            }
        }
    }
}
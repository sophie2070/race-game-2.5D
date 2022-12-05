using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlayerEndMove : MonoBehaviour
{
    Controller controller;
    WaypointDetection waypointDetection;
    EndScreen endScreen;

    //You can drag all your waypoints into this
    [SerializeField] Transform[] waypoints;
    [SerializeField] float speed = 1f;

    Quaternion targetRot;

    Vector3 target;

    int lastWaypoint = 0;
    private void Awake()
    {
        controller = GetComponent<Controller>();
        waypointDetection = GetComponent<WaypointDetection>();
        endScreen = GetComponent<EndScreen>();
    }

    private void Update()
    {
        if (endScreen.finished == true)
        {
            var currentWaypoint = waypointDetection.currentWaypoint;
            controller.ChangeSpeed(1);
            if (currentWaypoint != lastWaypoint)
            {
                target = waypoints[currentWaypoint].position;
                var dir = (target - transform.position).normalized;
                targetRot = Quaternion.LookRotation(dir, Vector3.up);
            }

            lastWaypoint = currentWaypoint;
            FacingWaypoint(targetRot);
        }
    }
    public void FacingWaypoint(Quaternion tRot)
    {
        transform.rotation = Quaternion.RotateTowards(transform.rotation, tRot, speed * 2 * Time.deltaTime);
    }
}
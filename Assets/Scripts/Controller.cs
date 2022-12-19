using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] float maxSpeed = 35;
    [SerializeField] float turnSpeed = 40;
    [SerializeField] float Accel = 12;
    [SerializeField] float speed = 0;
    [SerializeField] float Break = 12;
    Rigidbody rb;

    //\=-timers-=\//
    float speedBoostTime = 0;
    float driftBoostTime = 0;
    bool speedTime = false;
    bool driftTime = false;
    [SerializeField]
    float turnTimer;
    //\/\/\/\/\/\/\/\/\/\\

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    protected void LateUpdate()
    {
        transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y, 0);
    }
    public void ChangeSpeed(float throttle)
    {
        if (throttle != 0)
        {
            speed = speed + Accel * throttle * Time.deltaTime;
            speed = Mathf.Clamp(speed, -maxSpeed, maxSpeed);
        }
    }
    public void Brakeing(float breakingPower)
    {
        if (breakingPower != 0)
        {
            speed = speed - Break * breakingPower * Time.deltaTime;
            speed = Mathf.Clamp(speed, 0, maxSpeed);
        }
    }
    public void Turn(float direction)
    {
        transform.Rotate(0, direction * turnSpeed * Time.deltaTime, 0);
    }
    public void Idle()
    {
        if (!Mathf.Approximately(speed, 0))
        {
            if (speed < 0.01f)
            {
                speed = 0;
            }

            if (speed > 0)
            {
                speed -= 2*Time.deltaTime;
            }

            if (speed < 0)
            {
                speed += 2*Time.deltaTime;
            }

            speed = Mathf.Clamp(speed, -maxSpeed, maxSpeed);
        }
    }

    public void PowerSlideActive()
    {
        driftTime = true;
    }
    private void Update()
    {
        Vector3 velocity = Vector3.forward * speed;
        transform.Translate(velocity * Time.deltaTime, Space.Self);
        
        if(speedTime == true)
        {
            speedBoostTime += Time.deltaTime;
            maxSpeed = 50;
            speed = 50;
            if(speedBoostTime >= 0.7)
            {
                speedTime = false;
                maxSpeed = 35;
                speedBoostTime = 0;
            }
        }

        if (driftTime == true)
        {
            turnSpeed = 75;
            driftBoostTime += Time.deltaTime;
            if (driftBoostTime >= 0.8 && Input.GetKeyUp(KeyCode.RightShift))
            {
                driftBoostTime = 0;
                turnSpeed = 40;
                speedTime = true;
                driftTime = false;
            }
        }
    }
    public void SpeedBoost()
    {
        speedTime = true;
    }

   public void FacingWaypoint(Transform target)
    {
        float endTime = turnTimer * Time.deltaTime;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation, endTime);
    }
}

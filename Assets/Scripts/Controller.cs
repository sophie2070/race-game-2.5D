using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float maxSpeed = 25;
    public float turnSpeed = 50;
    public float Accel = 6;
    public float speed = 0;
    public float Break = 10;

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
        transform.Rotate(0, direction * turnSpeed * Time.deltaTime,0);
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
                speed -= Time.deltaTime;
            }

            if (speed < 0)
            {
                speed += Time.deltaTime;
            }

            speed = Mathf.Clamp(speed, -maxSpeed, maxSpeed);
        }
    }
    private void Update()
    {
        Vector3 velocity = Vector3.forward * speed;
        transform.Translate(velocity * Time.deltaTime, Space.Self);
    }
}

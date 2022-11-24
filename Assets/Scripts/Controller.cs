using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float maxSpeed = 200;
    public float turnSpeed = 500;
    public float Accel = 30;
    public float speed = 0;
    public float Break = 50;

    private void Update()
    {
        Vector2 velocity = Vector2.up * speed;
        transform.Translate(velocity * Time.deltaTime, Space.Self);
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

    public void Brakeing(int breakingPower)
    {
        speed -= Time.deltaTime * breakingPower;
    }

    public void turn(float direction)
    {
        transform.Rotate(0, 0, direction * -turnSpeed * Time.deltaTime);
    }

    public void Idle()
    {
        if (!Mathf.Approximately(speed, 0))
        {
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
       /*if (Mathf.Approximately(speed, 0))
        {
            speed = 0;
        }*/
    }
}

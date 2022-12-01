using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float maxSpeed = 35;
    public float turnSpeed = 40;
    public float Accel = 12;
    public float speed = 0;
    public float Break = 12;

    protected void LateUpdate()
    {
        transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y ,0);
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

    public void PowerSlideActive()
    {
        turnSpeed = 60;
    }

    public void PowerSlideOff()
    {
        turnSpeed = 40;
        speed = speed * 1.5f * Time.deltaTime;
        speed = Mathf.Clamp(speed, 35, 50);
    }
    private void Update()
    {
        Vector3 velocity = Vector3.forward * speed;
        transform.Translate(velocity * Time.deltaTime, Space.Self);
    }
}

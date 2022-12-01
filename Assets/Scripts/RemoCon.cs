using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoCon : MonoBehaviour
{
    [SerializeField]
    GameObject timerstart;
    public float forwards;
    public float turn;
    public float breakingPower;

    Controller controller;
    Countdown countdown;

    float verticalInput;
    float horizontalInput;
    float brake;
    

    private void Awake()
    {
        controller = GetComponent<Controller>();
        countdown = timerstart.GetComponent<Countdown>();

    }

    private void Update()
    {
        if (countdown.startrace == true)
        {
            verticalInput = Input.GetAxisRaw("Vertical");

            controller.ChangeSpeed(verticalInput * 2);

            if (verticalInput == 0) controller.Idle();

            horizontalInput = Input.GetAxisRaw("Horizontal");

            controller.Turn(horizontalInput * 2);

            if (horizontalInput == 0) controller.Idle();

            brake = Input.GetAxisRaw("Break");

            controller.Brakeing(brake * 2);

            if (Input.GetKey(KeyCode.LeftShift))
            {
                controller.PowerSlideActive();
            }
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                controller.PowerSlideOff();
            }


            controller.ChangeSpeed(forwards);
            controller.Turn(turn);
            controller.Brakeing(breakingPower);
        }
    }
}
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
    EndScreen EndScreen;

    float verticalInput;
    float horizontalInput;
    float brake;
    [SerializeField]
    Camera cam;
    [SerializeField]
    Camera cam1;
    

    private void Awake()
    {
        controller = GetComponent<Controller>();
        countdown = timerstart.GetComponent<Countdown>();
        EndScreen = GetComponent<EndScreen>();
    }

    private void Update()
    {
        if (countdown.startrace == true)
        {
            if (EndScreen.finished == false)
            {
                verticalInput = Input.GetAxisRaw("Vertical");

                controller.ChangeSpeed(verticalInput * 2);

                if (verticalInput == 0) controller.Idle();

                horizontalInput = Input.GetAxisRaw("Horizontal");

                controller.Turn(horizontalInput * 2);

                if (horizontalInput == 0) controller.Idle();

                brake = Input.GetAxisRaw("Break");

                controller.Brakeing(brake * 2);

                if(Input.GetKey(KeyCode.RightShift))
                {
                    controller.PowerSlideActive();
                }

                if(Input.GetKeyDown(KeyCode.E))
                {
                    cam.enabled = false;
                    cam1.enabled = true;
                }
                if (Input.GetKeyUp(KeyCode.E))
                {
                    cam.enabled = true;
                    cam1.enabled = false;
                }

                controller.ChangeSpeed(forwards);
                controller.Turn(turn);
                controller.Brakeing(breakingPower);
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoCon : MonoBehaviour
{
    public float forwards;
    public float turn;
    public float breakingPower;

    Controller controller;

    float verticalInput;
    float horizontalInput;
    float brake;

    private void Awake()
    {
        controller = GetComponent<Controller>();
    }

    private void Update()
    {
        verticalInput = Input.GetAxisRaw("Vertical");

        controller.ChangeSpeed(verticalInput * 2);

        if (verticalInput == 0) controller.Idle();

        horizontalInput = Input.GetAxisRaw("Horizontal");

        controller.Turn(horizontalInput * 2);

        if (horizontalInput == 0) controller.Idle();

        brake = Input.GetAxisRaw("Break");
       
        controller.Brakeing(brake * 2);

        controller.ChangeSpeed(forwards);
        controller.Turn(turn);
        controller.Brakeing(breakingPower);
        
    }
}
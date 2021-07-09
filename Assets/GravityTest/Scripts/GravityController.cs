using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    [SerializeField] private ControlOptions controlOption;
    [SerializeField] private float gravityMagnitude = 9.8f;


    private void Start()
    {
        // set the initial gravity
        // (not technically necessary - system has default gravity of -9.81)
        Physics.gravity = Vector3.down * gravityMagnitude;
    }

    private void FixedUpdate()
    {
        switch (controlOption)
        {
            case ControlOptions.Keyboard:
                KeyboardControls();
                break;
            case ControlOptions.Acceleration:
                AccelerationControls();
                break;
        }

    }

    private void AccelerationControls()
    {
        float x = Input.acceleration.x * gravityMagnitude;
        float y = Input.acceleration.y * gravityMagnitude;
        //float y = -gravityMagnitude;
        float z = -Input.acceleration.z * gravityMagnitude;

        Physics.gravity = new Vector3(x, y, z);
    }

    private void KeyboardControls()
    {
        float x= 0, y= -9.8f, z= 0;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            z = 9.8f;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            z -= 9.8f;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            x = 9.8f;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            x -= 9.8f;
        }

        if (Input.GetKey(KeyCode.W))
        {
            y *= -1.0f;
        }

        Physics.gravity = new Vector3(x, y, z);
    }
}

public enum ControlOptions
{
    Keyboard,
    Acceleration
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Plane1_Control : MonoBehaviour
{

    CharacterController _controller;
    public float speed = 7f;
    public float CountdownTimer;

    void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {
        if (CountdownTimer > 0)
        {
            CountdownTimer -= Time.deltaTime;
        }

        if (CountdownTimer <= 0)
        {
            Vector3 moveInput = Vector3.zero;

            if (Keyboard.current.wKey.isPressed) moveInput.y = 1f;
            if (Keyboard.current.sKey.isPressed) moveInput.y = -1f;
            if (Keyboard.current.aKey.isPressed) moveInput.x = 1f;
            if (Keyboard.current.dKey.isPressed) moveInput.x = -1f;

            // feed moveDirection with input.
            moveInput = new Vector3(0, moveInput.y, moveInput.x);
            moveInput = transform.TransformDirection(moveInput);

            // multiply it by speed.
            moveInput *= speed;

            _controller.Move(moveInput * Time.deltaTime);
        } 
    }
}
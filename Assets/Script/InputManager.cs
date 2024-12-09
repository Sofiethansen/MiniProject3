using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    // Used to manage input actions
    private PlayerInput playerInput;
    // It uses the OnFootActions map, that contains jump, movement and look
    private PlayerInput.OnFootActions onFoot;

    // Reference to another script - handles movement functionality
    private PlayerMotor motor;
    // Handles camera or player rotation based on look input
    private PlayerLook look;

    // This defines a read-only property called OnFoot that provides external access to the onFoot variable.
    public PlayerInput.OnFootActions OnFoot => onFoot;
    void Awake()
    {
        // Creates a new instance of the PlayerInput class, which manages all input actions.
        playerInput = new PlayerInput();
        // Assigns the OnFoot input action map
        onFoot = playerInput.OnFoot;

        // These components will handle movement and camera look functionality
        motor = GetComponent<PlayerMotor>();
        look = GetComponent<PlayerLook>();

        // the motor.Jump() method is called to execute the jump behavior.
        onFoot.Jump.performed += ctx => motor.Jump();


    }

    // Update is called once per frame
    void FixedUpdate()

    {
        // handles player movement logic
        motor.ProcessMove(onFoot.Movement.ReadValue<Vector2>());
    }

    private void LateUpdate()
    {
        // represents mouse input for camera control.
        look.ProcessLook(onFoot.Look.ReadValue<Vector2>());

    }
    //This ensures that input actions like Movement, Jump, and Look start responding to player input.
    private void OnEnable()
    {
        onFoot.Enable();
    }
    // This prevents input actions from being processed when the player or input system is not active.
    private void OnDisable()
    {
        onFoot.Disable();
    }
}

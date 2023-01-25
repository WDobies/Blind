using System;
using UnityEngine;

//process input
public class InputManager : MonoBehaviour
{
    public static Action OnFirePressed;

    private Controls                 controls;
    private Controls.KeyboardActions inputActions;
    private PlayerMovement           playerMovement;
    private CameraMovement           cameraMovement;


    private void Awake()
    {
        controls = new Controls();
        inputActions = controls.Keyboard;

        playerMovement = GetComponent<PlayerMovement>();
        cameraMovement = GetComponentInChildren<CameraMovement>();

    }

    private void FixedUpdate()
    {
        playerMovement.Move(inputActions.Movement.ReadValue<Vector2>());
        cameraMovement.RotateCamera(inputActions.Camera.ReadValue<Vector2>());

        if (inputActions.Fire.IsPressed())
            OnFirePressed?.Invoke();
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
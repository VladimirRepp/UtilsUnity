using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// KeyboardMover using Unity Input System
/// </summary>
public class KeyboardMover : MonoBehaviour
{
    [Header("Character Settings")]
    [SerializeField] private CharacterController _characterController;

    [Header("Movement Settings")]
    [SerializeField] private float _moveSpeed = 6.0f;
    [SerializeField] private float _flySpeed = 6.0f;
    [SerializeField] private bool _enableFly;

    private PlayerInput _input;

    public float MoveSpeed
    {
        get => _moveSpeed;
        set => _moveSpeed = value;
    }
    public float FlySpeed
    {
        get => _flySpeed;
        set => _flySpeed = value;
    }
    public bool EnableFly
    {
        get => _enableFly;
        set => _enableFly = value;
    }

    private void Awake()
    {
        _input = new PlayerInput();
    }

    private void OnEnable()
    {
        _input.Enable();
    }

    private void OnDisable()
    {
        _input.Disable();
    }

    private void Update()
    {
        Vector2 diraction = _input.PlayerActionMap.Move.ReadValue<Vector2>();
        Movement(diraction);

        if (_enableFly)
        {
            Vector2 axis = _input.PlayerActionMap.Fly.ReadValue<Vector2>();
            Fly(axis);
        }
    }

    private void Movement(Vector2 diraction)
    {
        float dx = diraction.x * Time.deltaTime * _moveSpeed;
        float dz = diraction.y * Time.deltaTime * _moveSpeed;

       _characterController.Move(transform.TransformDirection(new Vector3(dx, 0, dz)));
    }

    private void Fly(Vector2 axis)
    {
        float dy = 0;
        if (axis.y > 0)
        {
            dy = _flySpeed * Time.deltaTime;
        }
        if (axis.y < 0)
        {
            dy -= _flySpeed * Time.deltaTime;
        }
        
        _characterController.Move(transform.TransformDirection(new Vector3(0, dy, 0)));
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// MouseTurner using Unity Input System
/// </summary>
public class MouseTurner : MonoBehaviour
{
    [Header("Turn Settings")]
    [SerializeField] private Transform _turningObj; 
    [SerializeField] private float _rotationSpeedHor = 5.0f;

    private PlayerInput _input;

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
        Vector2 diraction = _input.PlayerActionMap.Look.ReadValue<Vector2>();
        Turner(diraction);
    }

    private void Turner(Vector2 diraction)
    {
        float delta = diraction.x * _rotationSpeedHor;
        float _rotationY = _turningObj.localEulerAngles.y + delta;

        _turningObj.localEulerAngles = new Vector3(0, _rotationY, 0);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// MouseLooker using Unity Input System
/// </summary>
public class MouseLooker : MonoBehaviour
{
    [Header("Main Settings")]
    [SerializeField] private ERorationAxes _rorationAxes = ERorationAxes.XandY;
    [SerializeField] private Transform _cameraTransform;

    [Header("Vertical Settings")]
    [SerializeField] private float _rotationSpeedHor = 5.0f;

    [Header("Horizontal Settings")]
    [SerializeField] private float _rotationSpeedVer = 5.0f;
    [SerializeField] private float maxVert = 45.0f;
    [SerializeField] private float minVert = -45.0f;

    private PlayerInput _input;
    private float _rotationX = 0;

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
        Looker(diraction);
    }

    private void Looker(Vector2 diraction)
    {
        float _rotationY = 0;

        if(_rorationAxes == ERorationAxes.X || _rorationAxes == ERorationAxes.XandY)
        {
            _rotationX -= diraction.y * _rotationSpeedVer;
            _rotationX = Mathf.Clamp(_rotationX, minVert, maxVert);
        }

        if (_rorationAxes == ERorationAxes.Y || _rorationAxes == ERorationAxes.XandY)
        {
            float delta = diraction.x * _rotationSpeedHor;
            _rotationY = _cameraTransform.localEulerAngles.y + delta;
        }

        _cameraTransform.localEulerAngles = new Vector3(_rotationX, _rotationY, 0);
    }
}

public enum ERorationAxes
{
    XandY,
    X,
    Y
}

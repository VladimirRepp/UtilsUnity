using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    [SerializeField] private float _speedRotation;

    private void Update()
    {
        Vector3 newRotation = new Vector3(0, 0, Time.deltaTime * _speedRotation);
        transform.Rotate(newRotation);
    }
}

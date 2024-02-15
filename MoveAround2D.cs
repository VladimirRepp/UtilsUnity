using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAround2D : MonoBehaviour
{
    [SerializeField] Transform _centerOfGravity;
    [SerializeField] float _speed;

    private void Update()
    {
        transform.RotateAround(_centerOfGravity.position, new Vector3(0, 0, 1), _speed * Time.deltaTime);
    }
}

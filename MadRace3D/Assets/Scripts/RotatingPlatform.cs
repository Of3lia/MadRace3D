using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatform : MonoBehaviour
{
    public float rotationSpeed = 0.5f;

    private void FixedUpdate()
    {
        transform.Rotate(Vector3.up * rotationSpeed, Space.Self);
    }
}

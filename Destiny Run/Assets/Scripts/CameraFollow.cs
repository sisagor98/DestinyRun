using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform targer;

    public float smSpeed = 0.125f;

    public Vector3 offser;

    private void FixedUpdate()
    {
        Vector3 desiredPosition = targer.position + offser;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(targer);
    }
}

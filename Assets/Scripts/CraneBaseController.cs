using System;
using UnityEngine;

public class CraneBaseController : MonoBehaviour
{
    public float rotationSpeed = 30f; // Degrees per second

    private float rotationDirection = 0f;

    private void Start()
    {
        Debug.Log("Testing crane rotation.");
    }

    void Update()
    {
        if (rotationDirection != 0f)
        {
            transform.Rotate(Vector3.up, rotationDirection * rotationSpeed * Time.deltaTime);
        }
    }

    public void SetRotationDirection(float direction)
    {
        rotationDirection = direction;
    }
}
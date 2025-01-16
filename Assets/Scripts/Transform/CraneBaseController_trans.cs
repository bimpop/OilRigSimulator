using UnityEngine;

public class CraneBaseController_trans : MonoBehaviour
{
    public float rotationSpeed = 30f; // Degrees per second

    private float rotationDirection = 0f;

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
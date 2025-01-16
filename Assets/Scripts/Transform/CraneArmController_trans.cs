using UnityEngine;

public class CraneArmController_trans : MonoBehaviour
{
    public float rotationSpeed = 30f; // Degrees per second
    public Transform armPivot; // Pivot point of the arm

    private float rotationDirection = 0f;

    void Update()
    {
        if (rotationDirection != 0f && armPivot != null)
        {
            armPivot.Rotate(Vector3.forward, rotationDirection * rotationSpeed * Time.deltaTime);
        }
    }

    public void SetRotationDirection(float direction)
    {
        rotationDirection = direction;
    }
}
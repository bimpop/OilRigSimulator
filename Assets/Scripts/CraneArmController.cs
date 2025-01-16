using UnityEngine;

[RequireComponent(typeof(HingeJoint))]
public class CraneArmController : MonoBehaviour
{
    private HingeJoint _hingeJoint;

    public float motorSpeed = 10f; // Speed when rotating
    public float motorForce = 200f; // Force applied by the motor

    // private Transform _baseTransform;

    void Start()
    {
        _hingeJoint = GetComponent<HingeJoint>();
        _hingeJoint.useMotor = true;

        // Find the base transform (assumes it's the parent)
        // _baseTransform = transform.parent;
    }

    // void Update()
    // {
    //     // Ensure the arm follows the base's rotation
    //     if (_baseTransform != null)
    //     {
    //         Quaternion baseRotation = _baseTransform.rotation;
    //         transform.rotation = baseRotation; // Sync rotation
    //     }
    // }

    public void SetRotationDirection(float direction)
    {
        JointMotor motor = _hingeJoint.motor;
        motor.targetVelocity = direction * motorSpeed;
        motor.force = motorForce;
        _hingeJoint.motor = motor;
    }
}
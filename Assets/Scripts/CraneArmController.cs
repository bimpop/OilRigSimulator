using UnityEngine;

[RequireComponent(typeof(HingeJoint))]
public class CraneArmController : MonoBehaviour
{
    private HingeJoint _hingeJoint;

    public float motorSpeed = 10f; // Speed when rotating
    public float motorForce = 200f; // Force applied by the motor

    void Start()
    {
        _hingeJoint = GetComponent<HingeJoint>();
        _hingeJoint.useMotor = true;
    }

    public void SetRotationDirection(float direction)
    {
        JointMotor motor = _hingeJoint.motor;
        motor.targetVelocity = direction * motorSpeed;
        motor.force = motorForce;
        _hingeJoint.motor = motor;
    }
}
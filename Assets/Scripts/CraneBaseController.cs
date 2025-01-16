using UnityEngine;
using Quaternion = System.Numerics.Quaternion;

[RequireComponent(typeof(HingeJoint))]
public class CraneBaseController : MonoBehaviour
{
    [SerializeField] private GameObject craneArm;
    
    private HingeJoint _hingeJoint;
    private Rigidbody _armRb;

    public float motorSpeed = 10f; // Speed when rotating
    public float motorForce = 200f; // Force applied by the motor

    void Start()
    {
        _hingeJoint = GetComponent<HingeJoint>();
        _hingeJoint.useMotor = true;

        _armRb = craneArm.GetComponent<Rigidbody>();
    }

    public void SetRotationDirection(float direction)
    {
        _armRb.isKinematic = direction != 0;
        
        JointMotor motor = _hingeJoint.motor;
        motor.targetVelocity = direction * motorSpeed;
        motor.force = motorForce;
        _hingeJoint.motor = motor;
    }
}
using UnityEngine;

public class CraneController : MonoBehaviour
{
    public CraneBaseController baseController;
    public CraneArmController armController;

    public void RotateBaseClockwise()
    {
        baseController.SetRotationDirection(1f);
    }

    public void RotateBaseCounterClockwise()
    {
        baseController.SetRotationDirection(-1f);
    }

    public void StopBaseRotation()
    {
        baseController.SetRotationDirection(0f);
    }

    public void RotateArmClockwise()
    {
        armController.SetRotationDirection(1f);
    }

    public void RotateArmCounterClockwise()
    {
        armController.SetRotationDirection(-1f);
    }

    public void StopArmRotation()
    {
        armController.SetRotationDirection(0f);
    }
}
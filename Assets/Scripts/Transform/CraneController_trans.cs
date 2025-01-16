using UnityEngine;

public class CraneController_trans : MonoBehaviour
{
    public CraneBaseController_trans baseController;
    public CraneArmController_trans armController;

    // These methods will be linked to buttons
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

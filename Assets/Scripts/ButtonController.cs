using UnityEngine;
using UnityEngine.Events;

public class ButtonController : MonoBehaviour
{
    private static readonly int IsPressed = Animator.StringToHash("isPressed");
    [SerializeField] private Animator animator;
    
    public UnityEvent onButtonPressed;
    public UnityEvent onButtonReleased;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PokeInteractor"))
        {
            // Debug.Log("Button pressed");
            onButtonPressed.Invoke();
            AnimateButtonPress(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PokeInteractor"))
        {
            // Debug.Log("Button released");
            onButtonReleased.Invoke();
            AnimateButtonPress(false);
        }
    }

    private void AnimateButtonPress(bool isPressed)
    {
        // Add animation logic here
        animator.SetBool(IsPressed, isPressed);
        // Vector3 targetPosition = isPressed ? transform.localPosition - Vector3.up * 0.02f : transform.localPosition + Vector3.up * 0.02f;
        // transform.localPosition = targetPosition;
    }
}
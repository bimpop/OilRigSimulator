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
        Debug.Log("Trigger pressed");
        if (other.CompareTag("PokeInteractor"))
        {
            Debug.Log("Button pressed");
            onButtonPressed.Invoke();
            animator.SetBool(IsPressed, true);
            // AnimateButtonPress(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PokeInteractor"))
        {
            Debug.Log("Button released");
            onButtonReleased.Invoke();
            animator.SetBool(IsPressed, false);
            // AnimateButtonPress(false);
        }
    }

    private void AnimateButtonPress(bool isPressed)
    {
        // Add animation logic here
        Vector3 targetPosition = isPressed ? transform.localPosition - Vector3.up * 0.02f : transform.localPosition + Vector3.up * 0.02f;
        transform.localPosition = targetPosition;
    }
}
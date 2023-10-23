using UnityEngine;
using UnityEngine.InputSystem;

// Script to set Animator for AI to different values

public class Animate_AI : MonoBehaviour
{
    // Instance variables
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        // get Animator component on start
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // 3 KEY PRESSED : BOW
        if (Keyboard.current.digit3Key.wasPressedThisFrame)
        {
            animator.SetBool("BowPressed", true);
        }

        else
        {
            animator.SetBool("BowPressed", false);
        }
    }
}

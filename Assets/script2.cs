using UnityEngine;
using UnityEngine.InputSystem; // for Keyboard.current
public class script2 : MonoBehaviour
{
    public float moveForce = 20f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; // keep upright
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        // --- 1️⃣ Read arrow key input manually ---
        float moveX = 0f;
        float moveZ = 0f;

        if (Keyboard.current.leftArrowKey.isPressed)  moveZ = -1f;
        if (Keyboard.current.rightArrowKey.isPressed) moveZ =  1f;
        if (Keyboard.current.upArrowKey.isPressed)    moveX = -1f;
        if (Keyboard.current.downArrowKey.isPressed)  moveX =  1f;

        Vector3 moveDirection = new Vector3(moveX, 0f, moveZ).normalized;

        // --- 2️⃣ Apply force if below max speed ---
        if (moveDirection.sqrMagnitude > 0)
        {
            rb.AddForce(moveDirection * moveForce, ForceMode.Acceleration);
        }
    }
}

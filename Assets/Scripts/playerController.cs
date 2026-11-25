using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private float movementX;

    public float movementSpeed = 0;
    public float jumpForce = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();     
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
    }

    void OnJump(InputValue jumpValue)
    {
        if (jumpValue.isPressed)
        {
            rb.AddForce(new Vector2(0f, 1f) * jumpForce, ForceMode2D.Impulse);
        }
    }

    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(movementX, 0.0f);

        rb.AddForce(movement * movementSpeed);
    }
}

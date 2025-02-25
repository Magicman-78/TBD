using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public float moveSpeed, runSpeed;

    private Rigidbody2D rb2d;
    private Vector2 moveAmount;

    private void Awake()
    {
        // Finds the rigidbody2D on the object
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Takes the moveAmount Vector2 value and multiplies it by moveSpeed to make it move
        rb2d.linearVelocity = moveAmount * moveSpeed;
    }

    // Gets the input from the controller or keyboard
    public void Move(InputAction.CallbackContext ctx)
    {
        // Changes the moveAmount equal to what it's reading from the input
        moveAmount=ctx.ReadValue<Vector2>();
    }

    // Interact action function
    public void Interact(InputAction.CallbackContext ctx)
    {
        // Checks if E is being pressed as opposed to being released
        if (ctx.ReadValue<float>() == 1)
        {
            // Write the circle or box cast here in order to interact with other things
            // Writes message in Console
            Debug.Log("I'm touching you");
        }
    }
}
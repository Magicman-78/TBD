using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine.InputSystem;
using System.Drawing;

public class Movement : MonoBehaviour
{
    public float moveSpeed, runSpeed;

    private Vector2 mousePos;

    public float cooldown, distance, angle;
    public Vector2 size;

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
    
    // Uses the position of the mouse and the direction that the player is facing and returns whatever the direction is
    public Vector2 GetInteractDirection()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mousePos - (Vector2)transform.position).normalized * distance;

        return direction;
    }

    // Interact action function
    public void Interact(InputAction.CallbackContext ctx)
    {
        // Checks if E is being pressed as opposed to being released
        if (ctx.ReadValue<float>() == 1)
        {
            // Write the circle or box cast here in order to interact with other things
            var hit = Physics2D.BoxCast(GetInteractSpot(), size, angle, Vector2.zero, 0);

            if (hit && hit.collider.CompareTag("StaticPartygoer"))
            {
                Debug.Log("Talking to static party-goer");
            }

            else
            {
                // Writes message in Console
                Debug.Log("Interacting");
            }
        }

    }
    
    // Returns the transform and position from the GetInteractionDirection
    private Vector2 GetInteractSpot()
    {
        return transform.position + (Vector3)GetInteractDirection();
    }

    // Draws a line and cube where the mouse is to show where the player is looking
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, transform.position + (Vector3)GetInteractDirection());
        Gizmos.DrawWireCube(GetInteractSpot(), size);
    }
}
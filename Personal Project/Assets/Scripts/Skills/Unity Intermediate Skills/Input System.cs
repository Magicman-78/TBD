using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))] // This script can only be added to a GameObject with a Rigibody2D
public class InputSystem : MonoBehaviour
{
    public float movementSpeed;

    private Rigidbody2D _rb;
    private Vector2 _moveAmount;

    void Awake()
    {
        // Set the _rb variable equal to this GameObject's rigidbody
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _rb.linearVelocityX = _moveAmount.x * movementSpeed;
    }

    public void HandleMovement(InputAction.CallbackContext ctx)
    {
        Debug.Log(ctx.ReadValue<Vector2>());
    }
}

using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Playerstats")]

    [SerializeField] float moveSpeed;
    [SerializeField] float jumpForce;

    Vector2 moveVector;

    Rigidbody2D PlayerRb;

    private void Start()
    {
        PlayerRb = GetComponent<Rigidbody2D>();
    }


    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Debug.Log("Jump");
            Jump();
        }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveVector = context.ReadValue<Vector2>();
    }



}

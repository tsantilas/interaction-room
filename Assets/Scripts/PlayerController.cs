using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 6.0f;

    public float rbDrag = 6.0f;

    float horizontalMovement;
    float verticalMovement;

    Vector3 moveDirection;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void FixedUpdate()
    {
        UserInput();
        ControlDrag();
        PlayerMovement();
    }

    void UserInput()
    {
        horizontalMovement = Input.GetAxisRaw("Horizontal");
        verticalMovement = Input.GetAxisRaw("Vertical");

        moveDirection = transform.forward * verticalMovement + transform.right * horizontalMovement;
    }

    void ControlDrag()
    {
        rb.drag = rbDrag;
    }

    void PlayerMovement()
    {
        rb.AddForce(moveDirection.normalized * moveSpeed, ForceMode.Acceleration);
    }

}
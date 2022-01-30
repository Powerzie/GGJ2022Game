using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 1;
    public float JumpForce = 300f;
    public float RotationSpeed = 20f;
    public  float MAX_SPEED = 8;

    private Rigidbody targetRigidbody;
    private bool _isGrounded;
    private bool isDisabled = false;

    void Start()
    {
        targetRigidbody = GetComponent<Rigidbody>();

    }
    public void DisablePlayerMovement()
    {
        isDisabled = true;
    }
     public void EnablePlayerMovement()
    {
        isDisabled = false;
    }
    private void FixedUpdate()
    {
        if (isDisabled)
            return;
       if( targetRigidbody.velocity.magnitude <= MAX_SPEED && targetRigidbody.velocity.magnitude >= MAX_SPEED*-1)
            MovementLogic();
    }
    private void MovementLogic()
    {

        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        if (moveHorizontal != 0.0f || moveVertical != 0.0f)
        {
            Vector3 movement;
            movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            if (moveHorizontal != 0.0f && moveVertical != 0.0f)
                movement *= 0.75f;

            Quaternion rotationTo = Quaternion.LookRotation(movement, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotationTo, RotationSpeed);
            targetRigidbody.AddForce(movement * Speed * Time.deltaTime, ForceMode.VelocityChange);
        }
    }
}

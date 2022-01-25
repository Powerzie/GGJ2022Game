using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 30;
    public float JumpForce = 300f;
    public const float MAX_SPEED = 100;

    public Vector3 startMovementSpeed;
    private Rigidbody targetRigidbody;
    private bool _isGrounded;


    void Start()
    {
        targetRigidbody = GetComponent<Rigidbody>();
        startMovementSpeed = new Vector3(1.0f, 0.0f, 1.0f);
    }
    private void FixedUpdate()
    {
        MovementLogic();
    }
  private  void MovementLogic()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement;
        if (moveHorizontal!=0.0f && moveVertical!=0.0f)
        {
            movement = new Vector3(moveHorizontal, 0.0f, moveVertical)*0.75f;
        }
        else
        {
            movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        }

        targetRigidbody.AddForce(movement * Speed);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 1;
    public float JumpForce = 300f;
    public  float MAX_SPEED = 8;

    private Rigidbody targetRigidbody;
    private bool _isGrounded;


    void Start()
    {
        targetRigidbody = GetComponent<Rigidbody>();

    }
    private void FixedUpdate()
    {
       if( targetRigidbody.velocity.magnitude <= MAX_SPEED && targetRigidbody.velocity.magnitude >= MAX_SPEED*-1)
            MovementLogic();
    }
  private  void MovementLogic()
    {

        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        Vector3 movement;
        if (moveHorizontal!=0.0f && moveVertical!=0.0f)
        {
            movement = new Vector3(moveHorizontal, 0.0f, moveVertical)*0.75f;
        }
        else
        {
            movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        }

        targetRigidbody.AddForce(movement * Speed * Time.deltaTime,ForceMode.VelocityChange);
    }
}

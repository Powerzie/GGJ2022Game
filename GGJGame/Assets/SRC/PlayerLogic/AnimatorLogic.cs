using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum PlayerAnimationsTrigers { Idle, Walk };
public class AnimatorLogic : MonoBehaviour
{
    private Animator animator;
    private bool trigerred = false;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
            if(Input.GetKey("a") || Input.GetKey("w") || Input.GetKey("d") || Input.GetKey("s") )
            {
                  if (!trigerred)
                  {
                      animator.SetBool(PlayerAnimationsTrigers.Walk.ToString(), trigerred = true);
                  }
            } 
           else
            {
            animator.SetBool(PlayerAnimationsTrigers.Walk.ToString(), trigerred = false);
            }
    }
}

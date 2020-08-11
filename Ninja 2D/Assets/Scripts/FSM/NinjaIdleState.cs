using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaIdleState : NinjaBaseState
{
    private float horizontalMove = 0f;

    public override void EnterState(Ninja_FSM ninja)
    {
    }

    public override void FixedUpdate(Ninja_FSM ninja)
    {
        ninja.Rigidbody.velocity = new Vector2(horizontalMove * Time.deltaTime, 0);
    }

    public override void OnCollisionEnter2D(Ninja_FSM ninja)
    {
    }

    public override void Update(Ninja_FSM ninja)
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * ninja.moveSpeed;

        if (Input.GetKeyDown("space"))
        {
            ninja.Rigidbody.AddForce(Vector3.up * ninja.jumpForce);
            ninja.TransitionToState(ninja.JumpingState);
        }

        if (Input.GetKeyDown("c"))
        {
            ninja.TransitionToState(ninja.CrouchingState);
        }
        
    }

}

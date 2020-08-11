using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ninja_FSM : MonoBehaviour
{
    public float moveSpeed = 40f;
    //float horizontalMove = 0f;

    public float jumpForce = 400f;

    public float crouchSpeed = 20f;
    
    private Rigidbody2D rbNinja;

   

    private NinjaBaseState currentState;

    public readonly NinjaIdleState IdleState = new NinjaIdleState();
    public readonly NinjaRunningState RunningState = new NinjaRunningState();
    public readonly NinjaJumpingState JumpingState = new NinjaJumpingState();
    public readonly NinjaCrouchingState CrouchingState = new NinjaCrouchingState();

    public NinjaBaseState CurrentState
    {
        get { return currentState; }
    }

    public Rigidbody2D Rigidbody
    {
        get { return rbNinja; }
    }

    //public float HorizontalMove
    //{
    //    get { return horizontalMove; }
    //}

    private void Awake()
    {
        rbNinja = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        TransitionToState(IdleState);
    }

    public void TransitionToState(NinjaBaseState state)
    {
        currentState = state;
        currentState.EnterState(this);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        currentState.OnCollisionEnter2D(this);
    }

    private void Update()
    {
        currentState.Update(this);
    }

    private void FixedUpdate()
    {
        currentState.FixedUpdate(this);
    }
}

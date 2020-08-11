using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaJumpingState : NinjaBaseState
{
    public override void EnterState(Ninja_FSM ninja)
    {
    }

    public override void FixedUpdate(Ninja_FSM ninja)
    {
    }

    public override void OnCollisionEnter2D(Ninja_FSM ninja)
    {
        ninja.TransitionToState(ninja.IdleState);
    }

    public override void Update(Ninja_FSM ninja)
    {
    }
}

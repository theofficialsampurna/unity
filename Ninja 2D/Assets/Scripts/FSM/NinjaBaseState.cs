using UnityEngine;

public abstract class NinjaBaseState 
{

    public abstract void EnterState(Ninja_FSM player);

    public abstract void Update(Ninja_FSM player);
    
    public abstract void FixedUpdate(Ninja_FSM player);

    public abstract void OnCollisionEnter2D(Ninja_FSM player);

   
}

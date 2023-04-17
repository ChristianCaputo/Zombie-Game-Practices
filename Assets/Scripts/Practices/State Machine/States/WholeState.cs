using UnityEngine;

public class WholeState : BaseState
{
    public override void EnterState(StateManager state)
    {
        Debug.Log("Hello from the wholestate!");
    }

    public override void UpdateState(StateManager state){}

    public override void OnCollisionEnter(StateManager state){}
}

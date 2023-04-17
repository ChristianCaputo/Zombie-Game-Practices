using UnityEngine;

public class GrowingState : BaseState
{
    Vector3 startingSize = new Vector3 (0.1f, 0.1f, 0.1f);
    Vector3 scalarSize = new Vector3 (0.1f, 0.1f, 0.1f);


    public override void EnterState(StateManager state)
    {   
        // seteo del tamaño inicial de la calabaza cuando se instancia por primera vez
        state.transform.localScale = startingSize;
    }

    public override void UpdateState(StateManager state)
    {
        if(state.transform.localScale.x <1)
        {
            state.transform.localScale += scalarSize * Time.deltaTime;
        }
        else
        {
            state.SwitchState(state.wholeState);
        }
    }

    public override void OnCollisionEnter(StateManager state){}
}

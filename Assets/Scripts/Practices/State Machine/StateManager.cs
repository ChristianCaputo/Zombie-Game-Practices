using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// CLASE CONTEXTO

public class StateManager : MonoBehaviour
{
    BaseState currentState; // referencia al estado actual
    
    public WholeState wholeState = new WholeState();
    public RottenState rottenState = new RottenState();
    public ChewedState chewedState = new ChewedState();
    public GrowingState growingState = new GrowingState();

    // Start is called before the first frame update
    void Start()
    {
        // estado inicial de la maquina de estados
        currentState = growingState;
        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState (BaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }

}

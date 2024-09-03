using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBaseState : IPlayerState
{
    protected StateMachine<IPlayerState, PlayerControl> stateMachine;
    public PlayerBaseState(StateMachine<IPlayerState,PlayerControl> stateMachine) 
    {
        this.stateMachine = stateMachine;
    }

    public virtual void Enter() { }

    public virtual void Exit() { }

    public virtual void Update() { }
}

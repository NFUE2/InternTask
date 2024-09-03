using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBaseState : IPlayerState
{
    protected PlayerStateMachine stateMachine;
    public PlayerBaseState(PlayerStateMachine stateMachine) 
    {
        this.stateMachine = stateMachine;
    }

    public virtual void Enter() { }

    public virtual void Exit() { }

    public virtual void Update() { }
}

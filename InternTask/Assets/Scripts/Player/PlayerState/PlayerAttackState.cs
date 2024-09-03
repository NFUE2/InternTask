using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackState : PlayerBaseState
{
    private string tag = "Attack";

    public PlayerAttackState(PlayerStateMachine stateMachine) : base(stateMachine) { }

    public override void Enter()
    {
        base.Enter();
        stateMachine.StartAnimation(stateMachine.control.animationData.attack);
    }

    public override void Exit()
    {
        base.Exit();
        stateMachine.StopAnimation(stateMachine.control.animationData.attack);
    }

    public override void Update()
    {
        base.Update();
        if(GetNomalize()) stateMachine.ChangeState(stateMachine.idleState);
    }

    protected bool GetNomalize()
    {
        Animator animator = stateMachine.control.animator;

        var info = animator.GetCurrentAnimatorStateInfo(0);
        bool isTag = info.IsTag(tag);

        if (isTag && info.normalizedTime >= 1.0f) return true;

        return false;
    }
}

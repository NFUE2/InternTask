using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerAttackBaseState : PlayerBaseState
{
    protected const string tag = "Attack";
    protected PlayerAttackBaseState(StateMachine<IPlayerState, PlayerControl> stateMachine) : base(stateMachine) { }

    public abstract void Attack();

    protected bool GetNomalize()
    {
        Animator animator = stateMachine.control.animator;

        var info = animator.GetCurrentAnimatorStateInfo(0);
        bool isTag = info.IsTag(tag);

        if (isTag && info.normalizedTime >= 1.0f) return true;

        return false;
    }
}

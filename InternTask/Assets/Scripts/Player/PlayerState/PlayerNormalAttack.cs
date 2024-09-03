using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNormalAttack : PlayerAttackBaseState
{
    public PlayerNormalAttack(StateMachine<IPlayerState, PlayerControl> stateMachine) : base(stateMachine) { }

    public override void Enter()
    {
        base.Enter();

    }

    public override void Attack()
    {

    }
}

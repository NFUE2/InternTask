
using UnityEngine;

public class MonsterHurtState : MonsterBaseState
{
    public MonsterHurtState(MonsterStateMachine stateMachine) : base(stateMachine) { }

    public override void Enter()
    {
        base.Enter();
        stateMachine.StartAnimation(stateMachine.control.animationData.hurt);
    }

    public override void Exit()
    {
        base.Exit();
        stateMachine.StopAnimation(stateMachine.control.animationData.hurt);
    }

    public override void Update()
    {
        base.Update();
        if (GetNomalize()) stateMachine.ChangeState(stateMachine.idleState);
    }

    protected bool GetNomalize()
    {
        Animator animator = stateMachine.control.animator;

        var info = animator.GetCurrentAnimatorStateInfo(0);

        if (info.normalizedTime >= 1.0f) return true;

        return false;
    }
}

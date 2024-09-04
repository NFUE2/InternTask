using UnityEngine;

public class MonsterDieState : MonsterBaseState
{
    public MonsterDieState(MonsterStateMachine stateMachine) : base(stateMachine) { }

    public override void Enter()
    {
        base.Enter();
        stateMachine.StartAnimation(stateMachine.control.animationData.die);
    }
    
    public override void Exit()
    {
        base.Enter();
        stateMachine.StopAnimation(stateMachine.control.animationData.die);
    }
}

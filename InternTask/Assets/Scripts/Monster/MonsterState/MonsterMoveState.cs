
using UnityEngine;

public class MonsterMoveState : MonsterBaseState
{
    private float speed;
    private Transform transform,target;
    public MonsterMoveState(MonsterStateMachine stateMachine) : base(stateMachine) 
    {
        speed = stateMachine.control.data.speed;
        transform = stateMachine.control.transform;
        target = stateMachine.control.transform;
    }

    public override void Enter()
    {
        base.Enter();
        stateMachine.StartAnimation(stateMachine.control.animationData.move);
    }

    public override void Exit()
    {
        base.Exit();
        stateMachine.StopAnimation(stateMachine.control.animationData.move);
    }

    public override void Update()
    {
        base.Update();
        if(transform.position != target.position)
        {
            transform.position = 
                Vector2.MoveTowards(transform.position,target.position,speed * Time.deltaTime);
        }
        else stateMachine.ChangeState(stateMachine.idleState);
    }
}

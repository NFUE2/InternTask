
using UnityEngine;

public class MonsterMoveState : MonsterBaseState
{
    private float speed;
    private Transform transform,target;
    private Vector2 destination;
    public MonsterMoveState(MonsterStateMachine stateMachine) : base(stateMachine) 
    {
        speed = stateMachine.control.data.speed;
        transform = stateMachine.control.transform;
        target = stateMachine.control.target;
        destination = target.position + new Vector3(0,-0.5f);
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
        if((Vector2)transform.position != destination)
        {
            transform.position = 
                Vector2.MoveTowards(transform.position,destination,speed * Time.deltaTime);
        }
        else stateMachine.ChangeState(stateMachine.idleState);
    }
}

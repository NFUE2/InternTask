
using UnityEngine;

public class MonsterMoveState : MonsterBaseState
{
    private float speed;
    private Transform transform, destination;

    public MonsterMoveState(MonsterStateMachine stateMachine) : base(stateMachine) 
    {
        speed = stateMachine.control.data.speed;
        transform = stateMachine.control.transform;
        destination = MapManager.Instance.destination;
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
        if(transform.position != destination.position)
        {
            transform.position = 
                Vector2.MoveTowards(transform.position,destination.position,speed * Time.deltaTime);
        }
        else stateMachine.ChangeState(stateMachine.idleState);
    }
}

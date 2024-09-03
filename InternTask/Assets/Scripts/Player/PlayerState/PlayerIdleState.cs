using UnityEngine;

public class PlayerIdleState : PlayerBaseState
{
    private float lastAttackTime;
    private GameObject box;
    private LayerMask enemy;

    public PlayerIdleState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
        lastAttackTime = -float.MaxValue;
        box = stateMachine.control.battleBox;
        enemy = stateMachine.control.enemy;
    }

    //public override void Enter()
    //{
    //    base.Enter();
    //    stateMachine.StartAnimation(stateMachine.control.animationData.idle);
    //}

    public override void Exit()
    {
        base.Exit();
        //stateMachine.StopAnimation(stateMachine.control.animationData.idle);
        lastAttackTime = Time.time;
    }

    public override void Update()
    {
        base.Update();
        bool isTargeting = Physics2D.OverlapBox(box.transform.position,box.transform.lossyScale,0.0f,enemy);

        if(isTargeting && Time.time - lastAttackTime > 1.0f)
            stateMachine.ChangeState(stateMachine.attackState);
    }
}

using UnityEngine;

public class MonsterStateMachine : StateMachine<ICharacterState, MonsterControl>
{
    public MonsterIdleState idleState;
    public MonsterMoveState moveState;
    public MonsterHurtState hurtState;
    public MonsterDieState dieState;

    public MonsterStateMachine(MonsterControl control) : base(control)
    {
        idleState = new MonsterIdleState(this);
        moveState = new MonsterMoveState(this);
        hurtState = new MonsterHurtState(this);
        dieState = new MonsterDieState(this);

        ChangeState(moveState);
    }
}

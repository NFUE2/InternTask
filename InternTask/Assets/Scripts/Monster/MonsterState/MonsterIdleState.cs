using System.Diagnostics;

public class MonsterIdleState : MonsterBaseState
{
    public MonsterIdleState(MonsterStateMachine stateMachine) : base(stateMachine) 
    {
        stateMachine.control.condition.OnHit += Hit;
    }

    private void Hit()
    {
        float curhp = stateMachine.control.condition.curhp;
        bool isDie = curhp == 0;

        ICharacterState nextState = isDie ? 
            stateMachine.dieState : stateMachine.hurtState;

        stateMachine.ChangeState(nextState); 
    }
}
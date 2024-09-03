public class PlayerStateMachine : StateMachine<IPlayerState, PlayerControl>
{
    public PlayerIdleState idleState;
    public PlayerAttackState attackState;

    public PlayerStateMachine(PlayerControl control) : base(control) 
    {
        idleState = new PlayerIdleState(this);
        attackState = new PlayerAttackState(this);

        ChangeState(idleState);
    }
}
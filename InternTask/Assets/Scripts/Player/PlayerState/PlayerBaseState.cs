using System.Collections;
public class PlayerBaseState : CharacterBaseState<PlayerStateMachine>
{
    public PlayerBaseState(PlayerStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }
}
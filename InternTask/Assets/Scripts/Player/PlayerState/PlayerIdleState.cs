using UnityEngine;

public class PlayerIdleState : PlayerBaseState
{
    public PlayerIdleState(StateMachine<IPlayerState, PlayerControl> stateMachine) : base(stateMachine) { }



}

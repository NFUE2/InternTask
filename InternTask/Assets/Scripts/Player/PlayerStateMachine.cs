using Unity.VisualScripting;
using UnityEngine;

public class PlayerStateMachine : StateMachine<IPlayerState, PlayerControl>
{
    public PlayerStateMachine(PlayerControl control) : base(control) { }

    public void StartAnimation(string hash)
    {
        control.animator.SetBool(hash,true);
    }
    public void StopAnimation(string hash)
    {
        control.animator.SetBool(hash, false);
    }
}

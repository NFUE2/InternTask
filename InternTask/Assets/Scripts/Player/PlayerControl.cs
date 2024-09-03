using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private PlayerStateMachine stateMachine;
    public Animator animator;

    [field: SerializeField] public PlayerAnimationData animationData { get; private set; }

    private void Awake()
    {
        stateMachine = new PlayerStateMachine(this);
        animationData.Init();
    }

    private void Update()
    {
        stateMachine.curstate.Update();
    }
}

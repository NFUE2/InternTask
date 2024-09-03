using UnityEditor.Build.Pipeline;
using UnityEngine;

public class PlayerControl : CharacterControl
{
    [field: SerializeField] public PlayerAnimationData animationData { get; private set; }
    private PlayerStateMachine stateMachine;

    public GameObject battleBox;
    public LayerMask enemy;

    public void Awake()
    {
        animationData.Init();
        stateMachine = new PlayerStateMachine(this);
    }

    private void Update()
    {
        stateMachine.curstate.Update();
    }
}

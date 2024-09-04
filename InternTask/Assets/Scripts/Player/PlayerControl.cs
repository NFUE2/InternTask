using UnityEngine;

public class PlayerControl : CharacterControl
{
    private PlayerStateMachine stateMachine;

    public GameObject battleBox;
    public LayerMask enemy;
    [field: SerializeField] public PlayerAnimationData animationData { get; private set; }

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

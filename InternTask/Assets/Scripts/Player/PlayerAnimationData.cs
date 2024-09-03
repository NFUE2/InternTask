using UnityEngine;

public class PlayerAnimationData : AnimationData
{
    //[SerializeField] private string idleParameter = "idle";
    [SerializeField] private string attackParameter = "Attack";

    //public int idle { get; private set; }
    public int attack { get; private set; }

    public override void Init()
    {
        //idle = Animator.StringToHash(idleParameter);
        attack = Animator.StringToHash(attackParameter);
    }
}

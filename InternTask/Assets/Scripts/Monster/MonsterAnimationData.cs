using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAnimationData : AnimationData
{
    //[SerializeField] private string idleParameter = "Idle";
    [SerializeField] private string moveParameter = "Move";
    [SerializeField] private string hurtParameter = "Hurt";
    [SerializeField] private string dieParameter = "Die";

    //public int idle { get; private set; }
    public int move { get; private set; }
    public int hurt { get; private set; }
    public int die { get; private set; }

    public override void Init()
    {
        //idle = Animator.StringToHash(idleParameter);
        move = Animator.StringToHash(moveParameter);
        hurt = Animator.StringToHash(hurtParameter);
        die = Animator.StringToHash(dieParameter);
    }
}

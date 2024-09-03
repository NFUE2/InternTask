using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationData : MonoBehaviour
{
    [SerializeField] private string idleParameter = "idle";
    [SerializeField] private string attackNormalParameter = "attackN";
    [SerializeField] private string attackCriticalParameter = "attackC";

    public int idle { get; private set; }
    public int attackN { get; private set; }
    public int attackC { get; private set; }

    public void Init()
    {
        idle = Animator.StringToHash(idleParameter);
        attackN = Animator.StringToHash(attackNormalParameter);
        attackC = Animator.StringToHash(attackCriticalParameter);
    }
}

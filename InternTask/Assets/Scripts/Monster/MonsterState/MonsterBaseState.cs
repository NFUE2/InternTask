using System;
using UnityEngine;

public class MonsterBaseState : CharacterBaseState<MonsterStateMachine>
{
    public MonsterBaseState(MonsterStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }
}
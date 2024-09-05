using System.Collections;
using System.Linq.Expressions;
using UnityEngine;

public class MonsterControl : CharacterControl
{
    public MonsterCondition condition;
    public Transform target;

    public MonsterData data { get; private set; }
    private MonsterStateMachine stateMachine;

    [field: SerializeField] public MonsterAnimationData animationData { get; private set; }

    private void OnMouseDown()
    {
        UIManager.Instance.Show<MonsterInfoUI>(data);
    }

    public void Awake()
    {
        gameObject.name = gameObject.name.Replace("(Clone)", "");

        data = new MonsterData();
        data = DataManager.dict[gameObject.name];
        animationData.Init();

        stateMachine = new MonsterStateMachine(this);
    }

    private void Update()
    {
        stateMachine.curstate.Update();
    }
}

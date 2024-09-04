
public class CharacterBaseState<T> : ICharacterState 
{
    protected T stateMachine;

    public virtual void Enter() { }
    public virtual void Exit() { }
    public virtual void Update() { }
}

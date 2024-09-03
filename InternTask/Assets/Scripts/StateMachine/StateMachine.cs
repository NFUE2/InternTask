public class StateMachine<T1,T2> where T1 : IState where T2 : CharacterControl
{
    public T1 curstate { get; private set; }

    public T2 control { get; private set; }

    public StateMachine(T2 control) 
    {
        this.control = control;
    }

    public void ChangeState(T1 state)
    {
        curstate?.Exit();
        curstate = state;
        curstate?.Enter();
    }

    public void StartAnimation(int hash)
    {
        control.animator.SetBool(hash, true);
    }
    public void StopAnimation(int hash)
    {
        control.animator.SetBool(hash, false);
    }
}
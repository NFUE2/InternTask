public class StateMachine<T1,T2> where T1 : IState
{
    public  T1 curstate { get; private set; }
    
    public T2 control;

    public StateMachine(T2 control)
    {
        this.control = control;
    }

    public void ChangeState(T1 state)
    {
        curstate.Exit();
        curstate = state;
        curstate.Enter();
    }
}

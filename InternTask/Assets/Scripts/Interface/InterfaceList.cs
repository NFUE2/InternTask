public interface IState
{
    public void Enter();
    public void Exit();
}

public interface IPlayerState : IState
{
    public void Update();
}
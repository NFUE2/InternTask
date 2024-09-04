public interface IState
{
    public void Enter();
    public void Exit();
}

public interface ICharacterState : IState
{
    public void Update();
}

public interface IDamagable
{
    public void TakeDamage(float damage);
}
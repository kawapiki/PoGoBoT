namespace PoGoBoT.Logic.State
{
    public interface IState
    {
        IState Execute(Context ctx, StateMachine machine);
    }
}


namespace StatePattern.PatternCraft_State_KATA
{
    public interface State
    {
        public void MoveToState(Tank tank);
    }


    public class SiegeState : State
    {
        public void MoveToState(Tank tank)
        {
            tank.CanMove = false;
            tank.Damage = 20;
        }
    }

    public class TankState : State
    {
        public void MoveToState(Tank tank)
        {
            tank.CanMove = true;
            tank.Damage = 5;
        }
    }
}


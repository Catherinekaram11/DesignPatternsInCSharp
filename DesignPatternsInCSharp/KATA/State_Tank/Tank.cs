using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.PatternCraft_State_KATA
{
    public class Tank
    {
        private State currentState;
        private bool canMove;
        private int damage;
        public bool CanMove { get { return canMove; } set { canMove = value; } }
        public int Damage { get { return damage; } set { damage = value; } }
        public State state { get { return currentState; } set { currentState = value; currentState.MoveToState(this); } }

        public Tank()
        {
            currentState = new TankState();
            currentState.MoveToState(this);
        }


    }
}

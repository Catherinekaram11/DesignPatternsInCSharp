using System;

namespace StatePattern
{
    public class Account
    {
        private State currentState;
        public Account(State state)
        {
            currentState = state;
        }

        public Account()
        {
            currentState = new OpenState();
        }

        public State State { get { return currentState; }  set { currentState = value; } }


        public void Open()
        {
            Console.WriteLine("Opening Account with state : " + currentState);
            currentState.Open(this);
        }

        public void Draw()
        {
            Console.Write("Drawing from Account with state : " + currentState);
            currentState.Draw(this);
        }

        public void Close()
        {
            Console.WriteLine("Closing Account with state : " + currentState);
            currentState.Close(this);
        }

        public void Suspend()
        {
            Console.WriteLine("Suspending Account with state : " + currentState);
            currentState.Suspend(this);
        }
    }
}

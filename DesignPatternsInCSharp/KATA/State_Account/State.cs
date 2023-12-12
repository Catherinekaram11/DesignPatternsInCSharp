using System;


namespace StatePattern
{
    public interface State
    {
        public void Draw(Account account);
        public void Close(Account accountv);
        public void Open(Account account);

        public void Suspend(Account account);
    }



    public class OpenState : State
    {
        public OpenState() { }
        public void Draw(Account account)
        {
            Console.WriteLine("Drawing...");
        }

        public void Close(Account account)
        {
            Console.WriteLine("Closing Account..");
            account.State = new CLosedState();
        }

        public void Open(Account account)
        {
            Console.Write("Account already opened!");
        }

        public void Suspend(Account account)
        {
            Console.WriteLine("Suspending Account..");
            account.State = new SuspendedState();
        }
    }


    public class CLosedState : State
    {
        public CLosedState() { }
        public void Draw(Account account)
        {
            Console.WriteLine("Can't Draw from closed account..");
        }
        public void Close(Account account)
        {
            Console.WriteLine("Account already closed!");
        }
        public void Open(Account account)
        {
            Console.WriteLine("Reopening account..");
            account.State= new OpenState();
        }
        public void Suspend(Account account)
        {
            Console.WriteLine("Suspending Account..");
            account.State = new SuspendedState();
        }
    }

    public class SuspendedState : State
    {
        public SuspendedState() { }
        public void Draw(Account account)
        {
            Console.WriteLine("Can't draw from suspended account..");
        }

        public void Open(Account account)
        {
            Console.WriteLine("Cann't open suspended account..");
        }

        public void Close(Account account)
        {
            Console.WriteLine("Can't close suspended account..");
        }

        public void Suspend(Account account)
        {
            Console.WriteLine("Account already suspended..");
        }
    }

}



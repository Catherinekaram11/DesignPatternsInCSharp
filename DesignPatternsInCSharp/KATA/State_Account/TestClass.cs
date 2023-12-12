using Xunit;
using System;
using StatePattern.PatternCraft_State_KATA;
using StatePattern;

namespace DesignPatternsInCSharp.KATA.State_Account
{
    public class TestClass
    {
        [Fact]
        public void NewAccount_Open()
        {
            Account account = new Account();
            Assert.Equal("OpenState", account.State.GetType().Name );
        }
        [Fact]
        public void Account_Close()
        {
            Account account = new Account();
            account.Close();
            Assert.Equal("CLosedState", account.State.GetType().Name);
        }

        [Fact]
        public void OpenSusepndedAccount()
        {
            Account account = new Account();
            account.Suspend();
            account.Open();
            Assert.Equal("SuspendedState", account.State.GetType().Name) ;
        }
    }

}

using Xunit;
using System;
using StatePattern.PatternCraft_State_KATA;

public class TestClass
{
    private Random random = new Random();

    [Fact]
    public void _0_TankState()
    {
        Tank tank = new Tank();

        Assert.True(tank.CanMove);
        Assert.Equal(5, tank.Damage);
    }

    [Fact]
    public void _1_SiegeState()
    {
        Tank tank = new Tank();
        tank.state = new SiegeState();

        Assert.False(tank.CanMove);
        Assert.Equal(20, tank.Damage);
    }

    [Fact]
    public void _2_MixState()
    {
        Tank tank = new Tank();

        Assert.True(tank.CanMove);
        tank.state = new SiegeState();
        Assert.Equal(20, tank.Damage);
    }

    [Fact]
    public void _3_RandomTests()
    {
        for (int n = 0; n < 10; n++)
        {
            Tank tank = new Tank();
            var canMove = tank.CanMove;
            var damage = tank.Damage;

            for (int i = 0; i < 10; i++)
            {
                if (random.NextDouble() <= 0.5)
                {
                    tank.state = new SiegeState();
                    canMove = false;
                    damage = 20;
                }
                else
                {
                    tank.state = new TankState();
                    canMove = true;
                    damage = 5;
                }

                Assert.Equal(canMove, tank.CanMove);
                Assert.Equal(damage, tank.Damage);
            }
        }
    }
}
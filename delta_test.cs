using Xunit;

public class DeltaTests
{
    [Fact]
    public void Delta_1()
    {
        var f = new F_kwadratowa(1, -3, 2);

        double wynik = f.Delta();

        Assert.Equal(1, wynik);
    }

    [Fact]
    public void Delta_2()
    {
        var f = new F_kwadratowa(1, -2, 1);

        double wynik = f.Delta();

        Assert.Equal(0, wynik);
    }

    [Fact]
    public void Delta_3()
    {
        var f = new F_kwadratowa(1, 0, 5);

        double wynik = f.Delta();

        Assert.True(wynik < 0);
    }
}

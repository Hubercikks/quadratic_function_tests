using Xunit;

public class F_kwadratowa_Tests
{
    [Fact]
    public void Rozwiaz_DwaMiejscaZerowe()
    {
        var f = new F_kwadratowa(1, -3, 2);

        var wynik = f.Rozwiaz();

        Assert.Equal(1, wynik.x1);
        Assert.Equal(2, wynik.x2);
    }
}

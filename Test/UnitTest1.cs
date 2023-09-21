namespace Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        string firstName = "jamES";
        string lastName = "BonD";
        String expect = "BOND, james";
        String actual = v._38.Services.Utility.Getinfo(firstName,lastName);
        Assert.Equal(expect, actual);
    }
}

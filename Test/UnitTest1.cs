namespace Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        string firstName = "jamES";
        string lastName = "BonD";
        String expect = "BOND, james";
        String actual = v._38.Services.Utility.Getinfo(firstName, lastName);
        Assert.Equal(expect, actual);




    }
}
public class UniTest2
{

    [Fact]
    public void Test2()
    {
        String birthMonth = "april";
        string birthYear = "1996";
        string expect = "APRIL, 1996";
        string actual = v._38.Services.Utility.GetYear(birthMonth, birthYear);
        Assert.Equal(expect, actual);

    }



}
    
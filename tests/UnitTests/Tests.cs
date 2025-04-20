namespace UnitTests;

public class Tests
{
    [Test]
    public async Task Success()
    {
        await Task.CompletedTask;
    }

    [Test]
    public void Fail()
    {
        Assert.Fail("");
    }
}
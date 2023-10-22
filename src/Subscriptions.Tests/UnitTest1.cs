namespace Subscriptions.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        // Code snippets are only available for the latest version. Current version is 5.x
        var graphClient = new GraphServiceClient(requestAdapter);
        var result = await graphClient.Subscriptions.PostAsync(null);
        Assert.Pass();
    }
}
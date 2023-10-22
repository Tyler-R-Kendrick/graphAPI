namespace Subscriptions.Tests;
using Microsoft.Graph;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Test1()
    {
        // Code snippets are only available for the latest version. Current version is 5.x
        var graphClient = new GraphServiceClient(requestAdapter);
        var result = await graphClient.Subscriptions.PostAsync(null);
        Assert.Pass();
    }
}
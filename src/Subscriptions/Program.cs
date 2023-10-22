using Azure.Identity;
using Microsoft.Graph;

namespace Subscriptions;

public class Program
{
    public static async Task Main()
    {
        var settings = Settings.LoadSettings();
        
    }

    private static void InitializeGraph(Settings settings)
    {
        GraphHelper.InitializeGraphForUserAuth(settings,
            (info, cancel) =>
            {
                // Display the device code message to
                // the user. This tells them
                // where to go to sign in and provides the
                // code to use.
                Console.WriteLine(info.Message);
                return Task.FromResult(0);
            });
    }

    private static async Task DisplayAccessTokenAsync()
    {
        try
        {
            var userToken = await GraphHelper.GetUserTokenAsync();
            Console.WriteLine($"User token: {userToken}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error getting user access token: {ex.Message}");
        }
    }
}

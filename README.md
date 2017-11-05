# Power BI for .NET Standard [![NuGet](https://img.shields.io/nuget/v/PowerBI.Api.svg)](https://www.nuget.org/packages/PowerBI.Api/)

For the official SDK please go to their [repository](https://github.com/Microsoft/PowerBI-CSharp).

## Install from Nuget
`Install-Package PowerBI.Api`

## Usage: Calling the GetReports API in a netcoreapp2
In the official documentation you will find references to `UserPasswordCredential`. This class is not available in netcoreapp2. To get a token from Azure AD you will need to call the API directly as illustrated below.
```
private async Task<TokenCredentials> GetAccessToken()
{
    using (HttpClient client = new HttpClient())
    {
        string tenantId = "";
        var tokenEndpoint = "";
        var accept = "application/json";
        var userName = "";
        var password = "";
        var clientId = "";

        client.DefaultRequestHeaders.Add("Accept", accept);
        string postBody = null;

        postBody = $@"resource=https%3A%2F%2Fanalysis.windows.net/powerbi/api
                        &client_id={clientId}
                        &grant_type=password
                        &username={userName}
                        &password={password}
                        &scope=openid";

        var tokenResult = await client.PostAsync(tokenEndpoint, new StringContent(postBody, Encoding.UTF8, "application/x-www-form-urlencoded"));
        tokenResult.EnsureSuccessStatusCode();
        var tokenData = await tokenResult.Content.ReadAsStringAsync();

        JObject parsedTokenData = JObject.Parse(tokenData);

        var token = parsedTokenData["access_token"].Value<string>();
        return new TokenCredentials(token, "Bearer");
    }
}
public async Task<IActionResult> Index()
{

    var tokenCredentials = await GetAccessToken();


    // Create a Power BI Client object (it will be used to call Power BI APIs)
    using (var powerBiclient = new PowerBIClient(new Uri("https://api.powerbi.com/"), tokenCredentials))
    {

        // Get a list of all groupts
        var reports = powerBiclient.Groups.GetGroups();

        // Do anything you want with the list of groups.
    }
    return View();
}
```

## Usage: Conflict with Microsoft.Rest.ClientRuntime

Should you receive a conflict with Microsoft.Rest.ClientRuntime after adding the package, you just need to add a reference the latest version directly in your application by using:
`dotnet add package Microsoft.Rest.ClientRuntime`

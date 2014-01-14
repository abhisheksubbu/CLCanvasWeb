using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for RootObject
/// </summary>
public class User
{
    public string language { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string profileThumbnailUrl { get; set; }
    public string roleId { get; set; }
    public object siteUrlPrefix { get; set; }
    public bool accessibilityModeEnabled { get; set; }
    public object siteUrl { get; set; }
    public string timeZone { get; set; }
    public string userName { get; set; }
    public string locale { get; set; }
    public string fullName { get; set; }
    public string userId { get; set; }
    public string userType { get; set; }
    public string email { get; set; }
    public bool isDefaultNetwork { get; set; }
    public string profileId { get; set; }
    public string profilePhotoUrl { get; set; }
    public object networkId { get; set; }
    public string currencyISOCode { get; set; }
}

public class Organization
{
    public string name { get; set; }
    public bool multicurrencyEnabled { get; set; }
    public string namespacePrefix { get; set; }
    public string organizationId { get; set; }
    public string currencyIsoCode { get; set; }
}

public class Version
{
    public string season { get; set; }
    public string api { get; set; }
}

public class Parameters
{
    public string contactID { get; set; }
}

public class Dimensions
{
    public string maxHeight { get; set; }
    public string maxWidth { get; set; }
    public string width { get; set; }
    public string clientWidth { get; set; }
    public string clientHeight { get; set; }
    public string height { get; set; }
}

public class Environment
{
    public string locationUrl { get; set; }
    public Version version { get; set; }
    public string displayLocation { get; set; }
    public string uiTheme { get; set; }
    public Parameters parameters { get; set; }
    public Dimensions dimensions { get; set; }
}

public class Links
{
    public string chatterFeedItemsUrl { get; set; }
    public string chatterFeedsUrl { get; set; }
    public string chatterGroupsUrl { get; set; }
    public string chatterUsersUrl { get; set; }
    public string enterpriseUrl { get; set; }
    public string metadataUrl { get; set; }
    public string partnerUrl { get; set; }
    public string queryUrl { get; set; }
    public string recentItemsUrl { get; set; }
    public string restUrl { get; set; }
    public string searchUrl { get; set; }
    public string sobjectUrl { get; set; }
    public string userUrl { get; set; }
    public string loginUrl { get; set; }
}

public class Application
{
    public string name { get; set; }
    public string version { get; set; }
    public string @namespace { get; set; }
    public string authType { get; set; }
    public string referenceId { get; set; }
    public string applicationId { get; set; }
    public string canvasUrl { get; set; }
    public string developerName { get; set; }
}

public class Context
{
    public User user { get; set; }
    public Organization organization { get; set; }
    public Environment environment { get; set; }
    public Links links { get; set; }
    public Application application { get; set; }
}

public class Client
{
    public string targetOrigin { get; set; }
    public string instanceUrl { get; set; }
    public string oauthToken { get; set; }
    public string instanceId { get; set; }
}

public class RootObject
{
    public Context context { get; set; }
    public string algorithm { get; set; }
    public int issuedAt { get; set; }
    public string userId { get; set; }
    public Client client { get; set; }
}
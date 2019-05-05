using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer4Proj.Models
{
    public class Clients
    {
        internal static IEnumerable<Client> Get()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "oauthClient",
                    ClientName = "Example Client App Identity 4",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = new List<Secret>
                    {
                        new Secret("123456".Sha256())
                    },
                    AllowedScopes = new List<string> {"customAPI.read"}
                },


                new Client
                {
                    ClientId = "prvaApp",
                    ClientName = "Client Example First App",
                    AllowedGrantTypes = GrantTypes.Implicit,
                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile
                    },
                    //https://localhost:44369/
                    RequireConsent = false,
                    RedirectUris = {"https://localhost:44369/signin-oidc"},
                    PostLogoutRedirectUris = {"https://localhost:44369/signout-callback-oidc"},
                    FrontChannelLogoutUri = "https://localhost:44369/signout-oidc"
                },

                new Client
                {
                    ClientId = "drugaApp",
                    ClientName = "Client Example Second App",
                    AllowedGrantTypes = GrantTypes.Implicit,
                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile
                    },
                    //https://localhost:44381/
                    RequireConsent = false,
                    RedirectUris = {"https://127.0.0.1:44381/signin-oidc"},
                    PostLogoutRedirectUris = {"https://127.0.0.1:44381/signout-callback-oidc"},
                    FrontChannelLogoutUri = "https://127.0.0.1:44381/signout-oidc"
                }
            };
        }
    }
}

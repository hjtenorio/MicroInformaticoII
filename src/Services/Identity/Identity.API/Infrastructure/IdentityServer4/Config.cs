using IdentityServer4;
using IdentityServer4.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Identity.Infrastructure.IdentityServer4.Configuration
{
    public class Config
    {
        public static IEnumerable<ApiResource> GetApiResources() {
            return new List<ApiResource>
            {
                new ApiResource("AssetsITClient", "WebService AssetsIT")
            };
        }

        public static IEnumerable<IdentityResource> GetIdentityResources() {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId()
            };
        }

        public static IEnumerable<Client> GetClients(IConfiguration configuration) {
            return new List<Client>
            {
                new Client
                {
                    ClientName = "Assets IT Client",
                    ClientId = "client_api_flow",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets =
                    {
                        new Secret("012536EF-FRT0-4Y09-8PCA-XCTHBC2F12W".Sha256())
                    },
                    AllowedScopes =
                    {
                        "AssetsITClient",
                        IdentityServerConstants.StandardScopes.OfflineAccess
                    },
                    AllowOfflineAccess = true,
                    AccessTokenLifetime = configuration.GetValue<int>("TokenLifetimeSeconds")
                }
            };
        }
    }
}
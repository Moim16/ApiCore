using IdentityServer4.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Configuracion
{
        public class Config
        {
            public static IEnumerable<ApiResource> GetApiResources()
            {
                return new List<ApiResource>
                 {
                  new ApiResource("APICategories", "API de las categorias de DGI"),
                  new ApiResource("APIProducts", "API de los Productos de DGI")
                 };
            }

            public static IEnumerable<Client> GetClients()
            {
                return new List<Client>
            {
                 new Client
                 {
                   ClientId = "DGI",
                     // no interactive user, use the clientid/secret for authentication
                   AllowedGrantTypes = GrantTypes.ClientCredentials,
                          // secret for authentication
                         ClientSecrets =
                         {
                         new Secret("alfakey".Sha256())
                         },
                         // scopes that client has access to
                        AllowedScopes = { "APICategories", "APIProducts" }
                 }
             };
            }
        }
    }

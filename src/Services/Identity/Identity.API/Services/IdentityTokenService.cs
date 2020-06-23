using Identity.API.Models.Request;
using Identity.API.Models.Response;
using IdentityModel;
using IdentityServer4.ResponseHandling;
using IdentityServer4.Validation;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using IdpTokenResponse = IdentityServer4.ResponseHandling.TokenResponse;

namespace Identity.API.Services
{
    public class IdentityTokenService : ITokenProviderService
    {
        private readonly ITokenRequestValidator _requestValidator;
        private readonly IClientSecretValidator _clientValidator;
        private readonly ITokenResponseGenerator _responseGenerator;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public IdentityTokenService(
            ITokenRequestValidator requestValidator,
            IClientSecretValidator clientValidator,
            ITokenResponseGenerator responseGenerator,
            IHttpContextAccessor httpContextAccessor)
        {
            _requestValidator = requestValidator;
            _clientValidator = clientValidator;
            _responseGenerator = responseGenerator;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<IdentityTokenResponse> GetToken(IdentityTokenRequest request)
        {
            var parameters = new NameValueCollection
            {
                { "username", request.Username },
                { "password", request.Password },
                { "grant_type", request.GrantType },
                { "scope", request.Scope },
                { "refresh_token", request.RefreshToken },
                { "response_type", OidcConstants.ResponseTypes.Token }
            };

            var response = await GetIdpToken(parameters);

            return GetTokenResponse(response);
        }

        private async Task<IdpTokenResponse> GetIdpToken(NameValueCollection parameters)
        {
            var clientResult = await _clientValidator.ValidateAsync(_httpContextAccessor.HttpContext);

            if (clientResult.IsError)
            {
                return new IdpTokenResponse
                {
                    Custom = new Dictionary<string, object>
                    {
                        { "Error", "invalid_client" },
                        { "ErrorDescription", "Invalid client/secret combination" }
                    }
                };
            }

            var validationResult = await _requestValidator.ValidateRequestAsync(parameters, clientResult);

            if (validationResult.IsError)
            {
                return new IdpTokenResponse
                {
                    Custom = new Dictionary<string, object>
                    {
                        { "Error", validationResult.Error },
                        { "ErrorDescription", validationResult.ErrorDescription }
                    }
                };
            }

            return await _responseGenerator.ProcessAsync(validationResult);
        }

        private static IdentityTokenResponse GetTokenResponse(IdpTokenResponse response)
        {
            if (response.Custom != null && response.Custom.ContainsKey("Error"))
            {
                return new IdentityTokenResponse
                {
                    Error = response.Custom["Error"].ToString(),
                    ErrorDescription = response.Custom["ErrorDescription"]?.ToString()
                };
            }

            return new IdentityTokenResponse
            {
                AccessToken = response.AccessToken,
                RefreshToken = response.RefreshToken,
                ExpiresIn = response.AccessTokenLifetime,
                TokenType = "Bearer"
            };
        }
    }
}

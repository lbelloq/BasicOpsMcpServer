using System.ComponentModel;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using ModelContextProtocol.Server;

namespace BasicOps.McpServer.Tools;

internal class JwtTools
{
    [McpServerTool]
    [Description("Validates a JWT.")]
    public bool ValidateJwt(
        [Description("JWT")] string jwt,
        [Description("Signning key in Base64")] string signingKey,
        [Description("Whether to validate the token's lifetime. Defaults to TRUE.")] bool validateLifetime = true,
        [Description("If specified, the token's audience must match this value.")] string? audience = null,
        [Description("If specified, the token's issuer must match this value.")] string? issuer = null
    )
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(jwt);
        ArgumentException.ThrowIfNullOrWhiteSpace(signingKey);
        var validate_audience = !string.IsNullOrEmpty(audience);
        var validate_issuer = !string.IsNullOrEmpty(issuer);
        try
        {
            var key_bytes = Convert.FromBase64String(signingKey);
            var security_key = new SymmetricSecurityKey(key_bytes);
            var validation_parameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = security_key,
                ValidateIssuer = validate_issuer,
                ValidateAudience = validate_audience,
                ValidateLifetime = validateLifetime,
                ClockSkew = TimeSpan.Zero
            };
            if (validate_audience)
            {
                validation_parameters.ValidAudience = audience;
            }
            if (validate_issuer)
            {
                validation_parameters.ValidIssuer = issuer;
            }
            var handler = new JsonWebTokenHandler();
            var result = handler.ValidateTokenAsync(jwt, validation_parameters).GetAwaiter().GetResult();
            return result.IsValid;
        }
        catch
        {
            return false;
        }
    }
    
    [McpServerTool]
    [Description("List the claims a JWT has.")]
    public IDictionary<string, string> ListJwtClaims(
        [Description("JWT")] string jwt
    )
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(jwt);
        var handler = new JsonWebTokenHandler();
        var token = handler.ReadJsonWebToken(jwt);
        return token.Claims
            .GroupBy(claim => claim.Type)
            .ToDictionary(group => group.Key, group => string.Join(",", group.Select(claim => claim.Value)));
    }
    
    [McpServerTool]
    [Description("Returns the JWT's expiration date.")]
    public DateTime? GetJwtExpirationDate(
        [Description("JWT")] string jwt
    )
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(jwt);
        var handler = new JsonWebTokenHandler();
        var token = handler.ReadJsonWebToken(jwt);
        return token.ValidTo;
    }
}
﻿using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Gov.Jag.Spice.Public.Authentication
{
    public class SiteMinderAuthOptions : AuthenticationSchemeOptions
    {
        public const string AuthenticationSchemeName = "site-minder-auth";
        public static string Scheme => AuthenticationSchemeName;
    }

    public static class SiteminderAuthenticationExtensions
    {
        /// <summary>
        /// Add Authentication Handler
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="configureOptions"></param>
        /// <returns></returns>
        public static AuthenticationBuilder AddSiteminderAuth(this AuthenticationBuilder builder, Action<SiteMinderAuthOptions> configureOptions)
        {
            return builder.AddScheme<SiteMinderAuthOptions, SiteminderAuthenticationHandler>(SiteMinderAuthOptions.AuthenticationSchemeName, configureOptions);
        }
    }

    public class SiteminderAuthenticationHandler : AuthenticationHandler<SiteMinderAuthOptions>
    {
        private readonly ILogger _logger;
        private readonly IHostingEnvironment _environment;

        public SiteminderAuthenticationHandler(IOptionsMonitor<SiteMinderAuthOptions> configureOptions,
            ILoggerFactory loggerFactory,
            UrlEncoder encoder,
            ISystemClock clock,
            IHostingEnvironment environment)
             : base(configureOptions, loggerFactory, encoder, clock)
        {
            _environment = environment;
            _logger = loggerFactory.CreateLogger<SiteminderAuthenticationHandler>();
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            var smAuthToken = SiteMinderAuthenticationToken.CreateFromFwdHeaders(Request);
            if (!_environment.IsProduction() && smAuthToken.IsAnonymous())
            {
                smAuthToken = SiteMinderAuthenticationToken.CreateForDev(Request);
                Response.Cookies.Delete(SiteMinderAuthenticationToken.SM_TOKEN_NAME);
            }

            string claims = Context.Session.GetString("app.principal");
            if (!string.IsNullOrEmpty(claims))
            {
                var principal = claims.FromJwt();
                _logger.LogDebug($"Success (session): {principal.Identity.Name}");
                return AuthenticateResult.Success(new AuthenticationTicket(principal, SiteMinderAuthOptions.Scheme));
            }
            if (smAuthToken.IsAnonymous())
            {
                _logger.LogDebug($"NoResult");
                return AuthenticateResult.NoResult();
            }

            try
            {
                var principal = CreatePrincipalFor(smAuthToken);
                Context.Session.SetString("app.principal", principal.ToJwt());
                _logger.LogDebug($"Success (new): {principal.Identity.Name}");
                _logger.LogDebug($"smAuthToken: {smAuthToken}");
                return AuthenticateResult.Success(new AuthenticationTicket(principal, SiteMinderAuthOptions.Scheme));
            }
            catch (ApplicationException e)
            {
                _logger.LogError($"Fail to authenticate user with smAuthToken '{smAuthToken}': {e.Message}");
                return AuthenticateResult.Fail(e.Message);
            }
        }

        private static ClaimsPrincipal CreatePrincipalFor(SiteMinderAuthenticationToken smAuthToken)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Sid, smAuthToken.smgov_userguid),
                new Claim(ClaimTypes.Upn, smAuthToken.sm_universalid),
                new Claim(SiteMinderClaimTypes.NAME, smAuthToken.smgov_userdisplayname),
                new Claim(SiteMinderClaimTypes.DEPARTMENT, smAuthToken.smgov_department),
                new Claim(SiteMinderClaimTypes.ORG_CODE, smAuthToken.smgov_orgcode),
                new Claim(SiteMinderClaimTypes.COMPANY, smAuthToken.smgov_company)
            };

            return new ClaimsPrincipal(new ClaimsIdentity(claims, SiteMinderAuthOptions.Scheme));
        }
    }

    public static class JwtEx
    {
        public static string ToJwt(this ClaimsPrincipal principal)
        {
            var handler = new JwtSecurityTokenHandler();
            handler.OutboundClaimTypeMap.Clear();
            string token = handler.CreateEncodedJwt(new SecurityTokenDescriptor
            {
                Subject = (ClaimsIdentity)principal.Identity,
                Audience = "self",
                Issuer = "self",
            });

            return token;
        }

        public static ClaimsPrincipal FromJwt(this string jwt)
        {
            var handler = new JwtSecurityTokenHandler();
            handler.InboundClaimTypeMap.Clear();
            var claims = handler.ReadJwtToken(jwt).Claims;
            return new ClaimsPrincipal(new ClaimsIdentity(claims, SiteMinderAuthOptions.AuthenticationSchemeName));
        }
    }
}

﻿using OnlineShop.Application.Contracts.JWT;


namespace OnlineShop.BackOffice.WebApiEndpoint.Middlewares
{
    public class BlacklistMiddleware
    {
        private readonly RequestDelegate _next;
        public BlacklistMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context, IAppJwtBlacklistService jwtBlacklist)
        {
            var authorizationHeader = context.Request.Headers["Authorization"].FirstOrDefault();
            if (authorizationHeader != null)
            {
                var cleanHeader = authorizationHeader.Trim(new char[] { '[', ']', '{', '}', ' ' });
                var token = cleanHeader.Split(new string[] { "Bearer" }, StringSplitOptions.RemoveEmptyEntries).LastOrDefault();

                if (token != null && jwtBlacklist.IsInBlacklist(token).Result)
                {
                    context.Response.StatusCode = 401;
                    //await context.Response.WriteAsync("UnAuthorization");
                    return;
                }
            }
            await _next(context);
        }
    }
}

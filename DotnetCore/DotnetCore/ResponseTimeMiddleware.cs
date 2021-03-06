﻿using DotnetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCore
{
    public class ResponseTimeMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;
        public ResponseTimeMiddleware(RequestDelegate next, ILoggerFactory logFactory)
        {
            _next = next;
            _logger = logFactory.CreateLogger("ResponseTime");
        }
        public async Task Invoke(HttpContext context)
        {
            var watch = new Stopwatch();
            watch.Start();
            context.Response.OnStarting(() => {
                watch.Stop();
                var responseTimeForCompleteRequest = watch.ElapsedMilliseconds; 
                _logger.LogInformation("{duration}ms", responseTimeForCompleteRequest);
                return Task.CompletedTask;
            });
            await _next(context);
        }
    }
}
public static class MyMiddlewareExtensions
{
    public static IApplicationBuilder UseMyMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ResponseTimeMiddleware>();
    }
}

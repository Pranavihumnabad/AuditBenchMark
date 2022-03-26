using AuditBenchMark.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AuditBenchMark.Extensions
{
    public static class ExceptionMiddlewareExtension
    {
        private static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context => {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json"; 
                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    var exception = contextFeature.Error;
                    _log4net.Error($"{exception.Message} : {System.Reflection.MethodBase.GetCurrentMethod().DeclaringType}");
                    if (contextFeature != null)
                    {
                        await context.Response.WriteAsync(new BenchmarkResponseAuditType
                        {
                         
                        }.ToString());
                    }
                });
            });
        }


    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace SwaggerSample.Filters
{
    [AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
    public class ApiKeyFilterAttribute : Attribute, IResourceFilter
    {
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            // do nothing
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            var apiKey = context.HttpContext.Request.Headers["my-api-key"].ToString();
            if (apiKey != "1234")
            {
                context.HttpContext.Response.StatusCode = 401; // unauthorized
                context.Result = new ContentResult
                {
                    Content = "Invalid API Key"
                };

                return;
            }
        }
    }
}
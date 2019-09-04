using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;

namespace SwaggerSample.Filters
{
    /// <summary>
    /// Add Api Key as Parameter for Swagger
    /// </summary>
    public class ApiKeySwaggerFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (operation.Parameters == null)
            {
                operation.Parameters = new List<OpenApiParameter>();
            }

            operation.Parameters.Add(new OpenApiParameter()
            {
                In = ParameterLocation.Header,
                Name = "my-api-key",
                Required = true,
                Schema = new OpenApiSchema()
                {
                    Type = "string"
                }
            });
        }
    }
}
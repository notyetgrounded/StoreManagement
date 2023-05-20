using StoreManagement.Domain.Exceptions;
using System.Text.Json;

namespace StoreManagement.Presentation.WebApi.Middleware
{
    public class ExceptionHanlingMiddleware : IMiddleware
    {

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception error)
            {
                var response = context.Response;
                response.ContentType = "application/json";
                switch (error)
                {
                    case (NotFoundException ex):
                        context.Response.StatusCode = StatusCodes.Status404NotFound;
                        break;

                    case (BadRequestException ex):
                        context.Response.StatusCode = StatusCodes.Status400BadRequest;
                        break;

                    case (UnauthorizedException ex):
                        context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                        break;
                    case (FobiddenException ex):
                        context.Response.StatusCode = StatusCodes.Status403Forbidden;
                        break;

                    default:
                        context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                        break;
                }
                var result = JsonSerializer.Serialize(new { message = error?.Message });
                await response.WriteAsync(result);


            }
        }
    }
}

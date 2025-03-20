using HallOfFame.Application.Dtos.Responces;
using HallOfFame.Domain.Exceptions;
using System.Text.Json;

namespace HallOfFame.Api.Middlewares
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ErrorHandlingMiddleware> _logger;

        public ErrorHandlingMiddleware(RequestDelegate next, ILogger<ErrorHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (NotFoundException e)
            {
                await HandleExceptionAsync(context, StatusCodes.Status404NotFound,  e);

                _logger.LogError(e.Message);
            }
            catch (Exception e) 
            {
                await HandleExceptionAsync(context, StatusCodes.Status500InternalServerError, e);

                _logger.LogError(e.Message + e.StackTrace);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, int status, Exception exception)
        {
            var errorResponse = new ErrorResponse(exception.Message, status);

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = status;

            var jsonResponse = JsonSerializer.Serialize(errorResponse, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            return context.Response.WriteAsync(jsonResponse);
        }
    }
}
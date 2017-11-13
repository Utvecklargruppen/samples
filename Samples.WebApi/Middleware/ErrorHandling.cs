﻿// ReSharper disable UnusedMember.Global
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Samples.InfrastructureLayer.Exceptions;
using Samples.WebApi.Dtos;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Samples.WebApi.Middleware
{
    /// <summary>
    /// This is the error handling middleware.
    /// See http://stackoverflow.com/questions/38630076/asp-net-core-web-api-exception-handling
    /// </summary>
    public class ErrorHandling
    {
        private readonly ILogger _logger;
        private readonly RequestDelegate _next;

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorHandling"/> class.
        /// </summary>
        public ErrorHandling(RequestDelegate next, ILogger logger)
        {
            _next = next;
            _logger = logger;
        }

        /// <summary>
        /// This is where we catch any exception that we need to handle.
        /// </summary>
        public async Task Invoke(HttpContext context)
        {
            try
            {
                // must be awaited
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                await HandleExceptionAsync(context, ex);
            }
        }

        /// <summary>
        /// Handle an exception.
        /// </summary>
        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var statusCode = SetStatusCode(exception);

            return WriteExceptionAsync(context, exception, statusCode);
        }

        /// <summary>
        /// Set the status code of the http response.
        /// </summary>
        private static HttpStatusCode SetStatusCode(Exception exception)
        {
            // if it's not one of the expected exception, set it to 500
            var code = HttpStatusCode.InternalServerError;

            // Here you can set status code depending on exception thrown.
            switch (exception)
            {
                case NotImplementedException _:
                    code = HttpStatusCode.NotImplemented;
                    break;

                case ArgumentException _:
                case FormatException _:
                    code = HttpStatusCode.BadRequest;
                    break;

                case NotFoundException _:
                    code = HttpStatusCode.NotFound;
                    break;
            }

            return code;
        }

        /// <summary>
        /// Create the HttpError object that is sent in the http response.
        /// </summary>
        private static Task WriteExceptionAsync(HttpContext context, Exception exception, HttpStatusCode statusCode)
        {
            var response = context.Response;
            response.ContentType = "application/json";
            response.StatusCode = (int)statusCode;

            return response.WriteAsync(JsonConvert.SerializeObject(new HttpError(exception)));
        }
    }
}
using GerenciadorTarefas.Communication.Contants;
using GerenciadorTarefas.Communication.Responses;
using GerenciadorTarefas.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace GerenciadorTarefas.Api.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var exception = context.Exception is ApiException;

            if (exception)
            {
                HandleApiException(context);
            }
            else
            {
                ThrowUnkowError(context);
            }
        }

        private void HandleApiException(ExceptionContext context)
        {
            if (context.Exception is BadRequestException)
            {
                context.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                context.Result = new BadRequestObjectResult(new ErrorResponse(context.Exception.Message));
            }

            if (context.Exception is NotFoundException)
            {
                context.HttpContext.Response.StatusCode = StatusCodes.Status404NotFound;
                context.Result = new NotFoundObjectResult(new ErrorResponse(context.Exception.Message));
            }
        }

        private void ThrowUnkowError(ExceptionContext context)
        {
            context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.Result = new ObjectResult(new ErrorResponse(ResponseMessage.UNKNOW_ERROR));
        }
    }
}

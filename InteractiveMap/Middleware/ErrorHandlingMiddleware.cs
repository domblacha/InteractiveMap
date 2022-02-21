using InteractiveMap.Exceptions;

namespace InteractiveMap.Middleware
{
    public class ErrorHandlingMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {

                await next.Invoke(context);

            }
            catch (NotFoundExcepiton e)
            {

                context.Response.StatusCode = 404;
                await context.Response.WriteAsync(e.Message);

            }
            catch (Exception e)
            {

                context.Response.StatusCode = 500;
                await context.Response.WriteAsync(e.Message);


            }
        }
    }
}

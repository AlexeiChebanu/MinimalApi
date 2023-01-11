namespace MinimalApi.EndPointsFilters
{
    public class CustomEndPointFilter : IEndpointFilter
    {
        private readonly ILogger<CustomEndPointFilter> _logger;
        public CustomEndPointFilter(ILogger<CustomEndPointFilter> logger)
        {
            _logger = logger;
        }

        public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
        {
            _logger.LogInformation("Endpoint filter - before logic");

            var result = await next(context);

            _logger.LogInformation("Endpoint filter - after logic");

            return result;
        }
    }
}

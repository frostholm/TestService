using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Expressbank.TestService.Features.Infrastructure.Pipelines
{

    public class LoggingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly ILogger _logger;

        public LoggingBehavior(ILogger logger)
        {
            _logger = logger;
        }
        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken,
            RequestHandlerDelegate<TResponse> next)
        {
            //await Logger.InfoAsync($"Handling {typeof(TRequest).Name}");
            var name = typeof(TRequest).Name;
            using (_logger.BeginScope("Handling {name}"))
            {
                _logger.Log(LogLevel.Debug,"Processing");
            }

            var response = await next();
            //await Logger.InfoAsync($"Handled {typeof(TResponse).Name}");

            using (_logger.BeginScope("Handled {name}"))
            {
                _logger.Log(LogLevel.Debug, "Processing");
            }

            return response;
        }
    }

}

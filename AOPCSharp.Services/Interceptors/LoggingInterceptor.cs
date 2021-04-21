using Castle.DynamicProxy;
using Microsoft.Extensions.Logging;
using System;

namespace AOPCSharp.Services.Interceptors
{
    public class LoggingInterceptor : IInterceptor
    {
        private readonly ILogger<LoggingInterceptor> _logger;

        public LoggingInterceptor(ILogger<LoggingInterceptor> logger)
        {
            _logger = logger;
        }

        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("--------------------------------------------calling--------------------------------------------------");
            //_logger.LogDebug($"Calling method {invocation.TargetType}.{invocation.Method.Name}.");
            invocation.Proceed();
            Console.WriteLine("--------------------------------------------called--------------------------------------------------");
        }
    }
}

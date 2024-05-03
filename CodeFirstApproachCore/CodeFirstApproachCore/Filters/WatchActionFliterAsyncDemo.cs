using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace CodeFirstApproachCore.Filters
{
    public class WatchActionFliterAsyncDemo : IAsyncActionFilter
    {
        private  Stopwatch _watch ;
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            _watch = Stopwatch.StartNew();
            await next();

        }
        public async Task OnActionExecutedAsync(ActionExecutedContext context)
        {
            _watch.Stop();
            var elapsedMillsecond = _watch.ElapsedMilliseconds;
            Console.WriteLine($"Time take to complete the action : {elapsedMillsecond} ms");
        }

    }
}

using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace CodeFirstApproachCore.Filters
{
    public class WatchActionFilter : ActionFilterAttribute
    {
        private Stopwatch _watch;

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            _watch = Stopwatch.StartNew();
        }

        /// <inheritdoc />
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            _watch.Stop();
            var elapsedMillsecond = _watch.ElapsedMilliseconds;
            Console.WriteLine($"Time take to complete the action : {elapsedMillsecond} ms");
        }
    }
}

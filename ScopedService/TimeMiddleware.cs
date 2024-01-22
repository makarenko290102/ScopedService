
public class TimeMiddleware
{
    TimeService timeService;
    public TimeMiddleware(RequestDelegate next, TimeService timeService)
    {
        this.timeService = timeService;
    }
    public async Task Invoke(HttpContext context)
    {
        await context.Response.WriteAsync($"Time: {timeService.GetTime()}");
    }
}
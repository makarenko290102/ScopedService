

public interface ITimer
{
    string Time { get; }
}
public class Timer : ITimer
{
    public Timer()
    {
        Time = DateTime.Now.ToLongTimeString();
    }
    public string Time { get; }
}

public class TimeService
{
    private ITimer timer;
    public TimeService(ITimer timer)
    {
        this.timer = timer;
    }
    public string GetTime() => timer.Time;
}
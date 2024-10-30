public class Running : Activity
{
    private double Distance { get; }

    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return (Distance / Duration) * 60;
    }

    public override double GetPace()
    {
        return Duration / Distance;
    }
}
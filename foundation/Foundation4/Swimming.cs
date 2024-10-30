public class Swimming : Activity
{
    private int Laps { get; }

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return (Laps * 50) / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        return ((Laps * 50) / 1000.0 * 0.62) / Duration * 60;
    }

    public override double GetPace()
    {
        return Duration / ((Laps * 50) / 1000.0 * 0.62);
    }
}
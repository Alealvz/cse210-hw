public class Cycling : Activity
{
    private double Speed { get; }

    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        Speed = speed;
    }

    public override double GetDistance()
    {
        return (Speed * Duration) / 60;
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60 / Speed;
    }
}
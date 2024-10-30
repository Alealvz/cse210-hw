using System;

public class Activity
{
    protected DateTime Date { get; }
    protected int Duration { get; }

    public Activity(DateTime date, int duration)
    {
        Date = date;
        Duration = duration;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{Date.ToShortDateString()} {GetType().Name} ({Duration} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}
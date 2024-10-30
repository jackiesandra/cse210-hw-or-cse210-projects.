using System;

public abstract class Activity
{
    private DateTime date;
    private int duration; // in minutes

    protected Activity(DateTime date, int duration)
    {
        this.date = date;
        this.duration = duration;
    }

    public DateTime Date => date;
    public int Duration => duration;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {GetType().Name} ({Duration} min) - Distance: {GetDistance():0.0} " +
               (GetType().Name == "Swimming" ? "meters" : "miles") + 
               $", Speed: {GetSpeed():0.0} " +
               (GetType().Name == "Swimming" ? "m/s" : "mph") +
               $", Pace: {GetPace():0.0} min per {(GetType().Name == "Swimming" ? "lap" : "mile")}";
    }
}

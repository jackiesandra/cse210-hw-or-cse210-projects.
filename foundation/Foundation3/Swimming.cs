using System;

public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance() => laps * 50 / 1000.0; // in kilometers

    public override double GetSpeed() => GetDistance() / (Duration / 60.0); // kph

    public override double GetPace() => Duration / GetDistance(); // min per km
}

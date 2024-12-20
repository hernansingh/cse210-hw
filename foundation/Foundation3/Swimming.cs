public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int duration, int laps)
        : base("Natación", date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetDuration()) * 60;
    }

    public override double GetPace()
    {
        return GetDuration() / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetDuration()} min): distance {GetDistance():F1} miles, speed {GetSpeed():F1} mph, pace {GetPace():F1} min per mile";
    }

}

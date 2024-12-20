public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int duration, double speed)
        : base("Cycling", date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * GetDuration()) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

public override string GetSummary()
{
    return $"{GetDate()} Cycling ({GetDuration()} min): distance {GetDistance():F1} miles, speed {GetSpeed():F1} mph, pace {GetPace():F1} min per mile";
}

}
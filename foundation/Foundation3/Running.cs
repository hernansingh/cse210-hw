public class Running : Activity
{
    private double _distance; // en millas

    public Running(string date, int duration, double distance)
        : base("Carrera", date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetDuration()) * 60; // Velocidad en mph
    }

    public override double GetPace()
    {
        return GetDuration() / _distance; // Ritmo en minutos por milla
    }

    public override string GetSummary()
    {
        return $"{GetDate()} {GetName()} ({GetDuration()} min): distance {GetDistance()} miles, speed {GetSpeed()} mph, pace {GetPace()} min per mile";
    }

}
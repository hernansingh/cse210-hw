using System;
using System.Collections.Generic;

// Clase base
public abstract class Activity
{
    protected string _name;
    protected string _date;
    protected int _duration; // en minutos

    public Activity(string name, string date, int duration)
    {
        _name = name;
        _date = date;
        _duration = duration;
    }

    public string GetDate()
    {
        return _date;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetSummary();
}
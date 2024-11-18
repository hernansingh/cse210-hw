public class Fraction
{
    private int _top;

    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int _topNumber)
    {
        _top = _topNumber;
        _bottom = 1;
    }

    public Fraction(int _topNumber, int _bottomNumber)
    {
        _top = _topNumber;
        _bottom = _bottomNumber;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue()
    {
        double _finalValue = (double)_top / (double)_bottom;
        
        return _finalValue;
    }

}
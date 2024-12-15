public class SimpleGoal : Goal
{
    // Atributos
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, int points, bool isComplete)
        : base(shortName, description, points)
    {
        _isComplete = isComplete;
    }

    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }
    public bool GetIsComplete()
    {
        return _isComplete;
    }

    // Métodos
    public override void RecordEvent()
    {
        SetIsComplete(true);
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string status = _isComplete ? "[X]" : "[ ]";

        return $"{status} {_shortName} ({_description}) - {_points} puntos";
    }
}
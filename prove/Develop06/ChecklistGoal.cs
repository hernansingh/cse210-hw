public class ChecklistGoal : Goal
{
    // Atributos
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int amountCompleted, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }
    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
    public int GetAmountCompleted()
    {
        return _amountCompleted; 
    }

    public void SetTarget(int target)
    {
        _target = target; 
    }

    public int GetTarget()
    {
        return _target; 
    }

    public void SetBonus(int bonus)
    {
        _bonus = bonus; 
    }

    public int GetBonus()
    {
        return _bonus; 
    }

    // Métodos
    public override void RecordEvent()
    {
        _amountCompleted += 1;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return "";
    }

    public override string GetStringRepresentation()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description}) - {_amountCompleted}/{_target} Currently completed";
    }
}
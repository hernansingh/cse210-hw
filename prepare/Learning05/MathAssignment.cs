
public class MathAssignment : Assignment
{
    //Stat
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string stundentName, string topic, string textbookSection, string problems)
        : base(stundentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    //Behav
    public string GetHomewerkList()
    {
        return $"Section: {_textbookSection}, Problems: {_problems}";
    }
}

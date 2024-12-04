public class Assignment
{
    //Status

    protected string _studentName;
    protected string _topic;

    //Behavior

    public Assignment(string stundentName, string topic)
    {
        _topic = topic;
        _studentName = stundentName;
    }

    public void SetStudentName(string stundentName)
    {
        _studentName = stundentName;
    }

    public void SetTopic(string topic)
    {
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetSummary()
    {
        return $"Student: {_studentName}, Topic: {_topic}";
    }
}
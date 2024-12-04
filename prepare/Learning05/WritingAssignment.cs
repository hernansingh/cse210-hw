public class WritingAssignment : Assignment
{
    // Sta
    private string _title;

    // Constructor
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    // Beh
    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}

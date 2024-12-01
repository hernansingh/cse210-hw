
class Comments
{
    // Estados
    public string _personComment;
    public string _comment;

    // Constructor
    public Comments(string personComment, string comment)
    {
        _personComment = personComment;
        _comment = comment;
    }

    // Comportamiento
    public void PrintComments()
    {
        Console.WriteLine($"{_personComment}: {_comment}");
    }
}
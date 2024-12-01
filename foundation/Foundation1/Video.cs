using System;
using System.Collections.Generic;

class Video
{
    // Estados
    public string _author;
    public string _title;
    public int _durationInSeconds;
    public List<Comments> _comments;

    // Constructor
    public Video(string author, string title, int durationInSeconds)
    {
        _author = author;
        _title = title;
        _durationInSeconds = durationInSeconds;
        _comments = new List<Comments>();
    }

    // Comportamiento
    public int GetCommentsCount()
    {
        return _comments.Count;
    }

    public void AddComment(string person, string comment)
    {
        _comments.Add(new Comments(person, comment));
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"Video Details\nVideo title:{_title}\nVideo author:{_author}\nDuration:{_durationInSeconds}seconds\nComments ({GetCommentsCount()}):");

        foreach (Comments comment in _comments)
        {
            comment.PrintComments();
        }
    }
}
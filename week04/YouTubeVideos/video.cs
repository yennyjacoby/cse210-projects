using System;
using System.Transactions;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> Comments = new List<Comment>();


//CONSTRUCTOR
    public Video(string author, string title, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void StoreComments(Comment comment)
    {
        Comments.Add(comment);
    }

    public int NumberComments()
    {
        return Comments.Count;
    }

    public void DisplayTracking()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        
    }
}
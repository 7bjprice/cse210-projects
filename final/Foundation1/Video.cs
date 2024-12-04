using System.Net;
using System.Reflection;

class Video
{
    // attributes
    private string _title;

    private string _author;

    private string _date;

    private int _lengthSeconds;

    private List<Comment> comments = new List<Comment>{};

    // methods
    public Video(string title, string author, string date, int length)
    {
        _title = title;
        _author = author;
        _date = date;
        _lengthSeconds = length;
    }

    public int GetNumComments()
    {
        return comments.Count();
    }

    public void CreateComment(string text, string author, string date)
    {
        Comment newComment = new(text, author, date);
        comments.Add(newComment);
    }
    public void DisplayVideo()
    {
        Console.WriteLine( "╔══════════════════════════════════════╗");
        Console.WriteLine($"║ {_title,-36} ║");
        Console.WriteLine( "╠══════════════════════════════════════╣");
        Console.WriteLine($"║ Author:     {_author,-24} ║");
        Console.WriteLine($"║ Date:       {_date,-24} ║");
        Console.WriteLine($"║ Length:     {_lengthSeconds,-4} seconds{"",-12} ║");
        Console.WriteLine($"║ Comments:   {GetNumComments(),-24} ║");
        Console.WriteLine("╚══════════════════════════════════════╝");

        Console.WriteLine("\nComments:");
        foreach (Comment c in comments)
        {
            c.DisplayComment();
        }
    }
}
class Comment
{
    // attributes
    private string _text;
    
    private string _author;

    private string _date;

    // methods
    public Comment(string text, string author, string date)
    {
        _text = text;
        _author = author;
        _date = date;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"── {_author} ──");
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_text}\n");
    }
}
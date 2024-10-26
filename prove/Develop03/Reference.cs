//written by Bryson Price and Daniel Loveless
class Reference
{
    // Private fields to store the book, chapter, starting verse, and ending verse
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    // Constructor for a reference with a single verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = 0;  // No end verse specified
    }

    // Constructor for a reference with a range of verses
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    // Constructor that parses a reference string like "John 3:16-17"
    public Reference(string reference)
    {
        // Find positions of book name, chapter, and verses in the reference string
        int bookIndex = reference.IndexOf(' ');
        int chapterIndex = reference.IndexOf(':');
        int verseIndex;

        // Check if the reference has an end verse indicated by a hyphen
        if (reference.Contains('-'))
        {
            // If so, set the end verse to the parsed value after the hyphen
            verseIndex = reference.IndexOf('-');
            _endVerse = int.Parse(reference.Substring(verseIndex + 1));
        }
        else
        {
            // If no end verse, set end verse to 0 (indicating a single verse)
            verseIndex = reference.Length;
            _endVerse = 0;
        }

        // Extract the book name, chapter number, and starting verse
        _book = reference.Substring(0, bookIndex);
        _chapter = int.Parse(reference.Substring(bookIndex + 1, chapterIndex - bookIndex - 1));
        _startVerse = int.Parse(reference.Substring(chapterIndex + 1, verseIndex - chapterIndex - 1));
    }

    // Method to display the formatted reference
    public void Display()
    {
        Console.WriteLine($"{_book} {_chapter}:{_startVerse}-{_endVerse} ");
    }
}

class MathAssignment : Assignment
{
    private string _textbookSection;

    private string _problems;

    public MathAssignment(string textbookSection, string problems, string studentName, string topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
        _studentName = studentName;
        _topic = topic;

    }

    public string GetHomeworkList()
    {
        return $"Section: {_textbookSection} Problems {_problems}";
    }
}
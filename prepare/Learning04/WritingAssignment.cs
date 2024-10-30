using System.Reflection;

class WritingAssignment : Assignment
{
    private string _title;


    public WritingAssignment(string title, string studentName, string topic)
    {
        _title = title;
        _studentName = studentName;
        _topic = topic;
    }

    public string GetWritingInformation()
    {
        return $"{_title}";
    }
}
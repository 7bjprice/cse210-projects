using System.Data;
class ReadWrite
{
    public string GetGoal(string filename, string reference)
    {
        string goal = "";

        using (StreamReader sr = new StreamReader(filename))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                
            }
        }

        return goal.Trim();
    }

    public void WriteGoal(string filename, Goal goal)
    {
        // ensures user enters a valid filename
        if (string.IsNullOrEmpty(filename))
        {
            throw new ArgumentException("Filename cannot be null or empty.", nameof(filename));
        }

        //appends goal onto existing file
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            outputFile.WriteLine($"{goal.GetTitle()}|{goal.GetDescription()}|{goal.GetPointValue()}|{goal.GetIsComplete()}");
        }
    }

}

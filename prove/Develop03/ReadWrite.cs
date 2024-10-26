// Troy and Bryson
using System.Data;
class ReadWrite
{
    public string GetScripture(string filename, string reference)
    {
        string scripture = "";
        bool isScriptureLine = false;

        using (StreamReader sr = new StreamReader(filename))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string cleanLine = line.Trim();

                // Stop appending once a new REFERENCE is encountered
                if (cleanLine.StartsWith("REFERENCE: ") && isScriptureLine)
                {
                    isScriptureLine = false; // Stop after the first set of verses
                }

                // Start appending when the target reference is found
                if (cleanLine == $"REFERENCE: {reference}")
                {
                    isScriptureLine = true;
                    continue;  // Skip the line containing "REFERENCE: {reference}"
                }

                // If we're in the correct section, add the verse
                if (isScriptureLine && cleanLine.StartsWith("VERSE: "))
                {
                    scripture += cleanLine.Replace("VERSE: ", "\n");
                }
            }
        }

        return scripture.Trim();
    }

    public void WriteScripture(string reference, string verse, string filename)
    {
        // ensures user enters a valid filename
        if (string.IsNullOrEmpty(filename))
        {
            throw new ArgumentException("Filename cannot be null or empty.", nameof(filename));
        }

        //appends verse and reference onto existing file
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            outputFile.WriteLine($"\nREFERENCE: {reference}\n\nVERSE: {verse}");
        }
    }

}

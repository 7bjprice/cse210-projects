using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
// Work done by Calvin and Bryson
class Prompts
{
    public string NewPrompt()
    {
        List<string> items = new List<string>
        {"Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today what would it be?",
        "What am I looking forward to this week?",
        "How did I serve someone today?",
        "What is love? (baby don't hurt me no more)",
        "How did someone serve me today?",
        "What am I grateful for today?",
        "How have I felt God's love in my life today?"};
        Random random = new Random();
        int PromptIndex = random.Next(items.Count);
        string RandomPrompt = items[PromptIndex];
        return RandomPrompt;
        
    }
}


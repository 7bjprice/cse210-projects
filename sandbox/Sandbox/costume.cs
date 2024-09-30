class Costume
{
    //attributes (member variables)
    public string headWear;
    public string gloves;
    public string shoes;
    public string upperGarment;
    public string lowerGarment;
    public string accessory;

    //behaviors
    public void ShowWardrobe()
    {
        string result = "";
        result += $"Head: {headWear}\n";
        result += $"Hands: {gloves}\n";
        result += $"Feet: {shoes}\n";
        result += $"Torso: {upperGarment}\n";
        result += $"Legs: {lowerGarment}\n";
        result += $"Accessory: {accessory}\n";
        Console.WriteLine(result);
    }
}


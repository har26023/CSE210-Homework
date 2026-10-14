class Costume
{
    // Attributes
    public string _headwear = "";
    public string _upperGarment = "";
    public string _lowerGarment = "";
    public string _footwear = "";
    public string _accessories = "";

    // Behavior
    public void Output()
    {
        Console.WriteLine("Costume Pieces:");
        Console.WriteLine($"Head: {_headwear}");
        Console.WriteLine($"Torse: {_upperGarment}");
        Console.WriteLine($"Legs: {_lowerGarment}");
        Console.WriteLine($"Feet: {_footwear}");
        Console.WriteLine($"Other: {_accessories}");
    }
}
public class TheStrokes
{
    public string Name { get; set; }
    public string Genre { get; set; }
    public int YearFormed { get; set; }

    public TheStrokes(string name, string genre, int yearFormed)
    {
        Name = name;
        Genre = genre;
        YearFormed = yearFormed;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Band Name: {Name}");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"Year Formed: {YearFormed}");
    }
}
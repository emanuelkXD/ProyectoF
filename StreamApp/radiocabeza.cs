public class RadioCabeza
{
    public string Name { get; set; }
    public string Frequency { get; set; }
    public string Location { get; set; }

    public RadioCabeza(string name, string frequency, string location)
    {
        Name = name;
        Frequency = frequency;
        Location = location;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Radio Station Name: {Name}");
        Console.WriteLine($"Frequency: {Frequency}");
        Console.WriteLine($"Location: {Location}");
    }
}
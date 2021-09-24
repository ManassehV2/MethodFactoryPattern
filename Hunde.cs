using System;

public class Hunde: IAuto
{
    private string _name;
    public string Name
    {
        get => _name;
        set => _name = value;
    }
    public Hunde()
    {
        _name = "Hunde";
    }
    public void TurnOn()
    {
        Console.WriteLine($"{_name } is turned on!");
    }
    public void TurnOff()
    {
        Console.WriteLine($"{_name } is turned off!");
    }
}
using System;

public class Nissan: IAuto
{
    private string _name;
    public string Name
    {
        get => _name;
        set => _name = value;
    }
    public Nissan()
    {
        _name = "Nissan";
    }
    public void TurnOn()
    {
        Console.WriteLine($"{_name} is turned On!");
    }
    public void TurnOff()
    {
        Console.WriteLine($"{_name} is turned Off!");
    }
}
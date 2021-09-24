using System;

public class NullCar: IAuto
{
    private string _name;
    public string Name
    {
        get => _name;
        set => _name = value;
    }
    public NullCar()
    {
        _name = "Null Car";
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
using System;

public class Toyota: IAuto
{
    private string _name;
    public string Name
    {
        get => _name;
        set => _name = value;
    }
    public Toyota()
    {
        _name = "Toyota Tacoma";
    }
    public void TurnOn()
    {
        Console.WriteLine($"{_name } is turned off!");
    }
    public void TurnOff()
    {
        Console.WriteLine($"{_name } is turned off!");
    }
}
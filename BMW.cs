using System;

public class BMW: IAuto
{
    private string _name;
    public string Name
    {
        get => _name;
        set => _name = value;
    }
    public BMW()
    {
        _name = "BMW";
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
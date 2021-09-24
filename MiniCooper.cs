using System;

public class MiniCooper: IAuto
{
    private string _name;
    public string Name
    {
        get => _name;
        set => _name = value;
    }
    public MiniCooper()
    {
        _name = "Mini Cooper";
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
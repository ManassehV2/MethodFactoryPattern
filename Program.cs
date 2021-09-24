using System;

namespace factoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string carName = args[0];
            
            SimpleFactory factory = new SimpleFactory();
            
            IAuto car = factory.CreateInstance(carName); 
            car.TurnOn();
            car.TurnOff();

        }

        /* static IAuto createCar(string carName)
        {
            switch (carName)
            {
                case "toyota":
                    return new Toyota();
                case "bmw":
                    return new BMW();
                default:
                    return new NullCar();
            }

        } */
    }
}

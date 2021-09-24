using System;
using System.Collections.Generic;
using System.Reflection;

public class SimpleFactory
{
    Dictionary<string, Type> autos;

    public SimpleFactory()
    {
        LoadAllTypes();
    }
    public IAuto CreateInstance(string carName)
    {
        Type t = GetTypeToCreate(carName);

        if(t == null)
        {
            return new NullCar();
        }
        return Activator.CreateInstance(t) as IAuto;
    }
    Type GetTypeToCreate(string carName)
    {
        foreach(var auto in autos)
        {
            if(auto.Key.Contains(carName))
            {
                return autos[auto.Key];
            }

        }
        return null;
    }
    void LoadAllTypes()
    {
        autos = new Dictionary<string, Type>();
        Type[] allTypes = System.Reflection.Assembly.GetExecutingAssembly().GetTypes();

        foreach (Type t in allTypes)
        {
            if(t.GetInterface(typeof(IAuto).ToString()) != null)
            {
                autos.Add(t.Name.ToLower(), t);
            }
        }

    }
}
using System;
public class Car : IVehicle
{
    public string Start()
    {
        return string.Format("---Vehicle is Started---");
    }
    public string Accelerate()
    {
        return string.Format("---Vehicle is moving---");
    }
    public string Stop()
    {
        return string.Format("---Vehicle is Stoped---");
    }
}
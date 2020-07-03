using System;
public class Car : IVehicle
{
    public string VehicleStart()
    {
        return string.Format("---Vehicle is Started---");
    }
    public string VehicleAccelerate()
    {
        return string.Format("---Vehicle is moving---");
    }
    public string VehicleStop()
    {
        return string.Format("---Vehicle is Stoped---");
    }
}
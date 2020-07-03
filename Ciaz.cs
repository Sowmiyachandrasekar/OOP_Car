using System;
public class Ciaz : Engine , IVehicle
{
    Engine engine { get; set;}
    public Ciaz(Engine en)
    {
        this.engine=en;
    }
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
    public override void AddEngine()
    {
        Console.WriteLine(this.engine);
    }
    
}
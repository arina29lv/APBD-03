namespace CargoManager;

public abstract class Container
{
    public double CurrentLoad { get; set; }
    public double MaxLoad { get; set; }
    public double TareWeight { get; set; }
    public double Height { get; set; }
    public double Depth { get; set; }
    public string SerialNumber { get; set; }

    public Container(double currentLoad, double maxLoad, double tareWeight, double height, double depth, string type)
    {
        CurrentLoad = currentLoad;
        MaxLoad = maxLoad;
        TareWeight = tareWeight;
        Height = height;
        Depth = depth;
        SerialNumber = SerialNumGenerator.Generate(type);
    }

    public virtual void UnloadCargo()
    {
        CurrentLoad = 0;
    }

    public virtual void LoadCargo(double mass)
    {
        if (mass + CurrentLoad > MaxLoad)
            throw new OverfillExeption("Loading cargo is too big");
        CurrentLoad += mass;
    }

    public override string ToString()
    {
        return $"{SerialNumber} - Load: {CurrentLoad}/{MaxLoad} kg, Dimensions: {Height} x {Depth} cm, Tare: {TareWeight} x {TareWeight} kg";
    }
    
}
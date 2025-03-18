namespace CargoManager;

public class RefrigeratedContainer : Container
{
    public string ProductType { get; set; }
    public double Temperature { get; set; }

    public RefrigeratedContainer(double maxLoad, double height, double depth, double tareWeight, string productType,
        double temperature)
        : base("Refrigerated", 0, maxLoad, height, depth, tareWeight)
    {
        ProductType = productType;
        Temperature = temperature;
    }
        
}
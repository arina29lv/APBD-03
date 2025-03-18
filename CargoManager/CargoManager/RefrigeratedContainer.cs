namespace CargoManager;

public class RefrigeratedContainer : Container
{
    public string ProductType { get; set; }
    public double Temperature { get; set; }

    public RefrigeratedContainer(double maxLoad, double height, double depth, double tareWeight, string productType,
        double temperature)
        : base("Refrigerated", 0, maxLoad, height, depth, tareWeight)
    {
        if(!PossibleProducts.Products.ContainsKey(productType))
            throw new ArgumentException($"Product '{productType}' is not allowed in refrigerated container.");
        
        if(temperature < PossibleProducts.Products[ProductType])
            throw new ArgumentException($"Temperature {temperature} is too low for {ProductType}. Allowed: {PossibleProducts.Products[ProductType]} degrees.");
        
        ProductType = productType;
        Temperature = temperature;
    }

    public override string ToString()
    {
        return base.ToString() + $", Product: {ProductType}, Temperature: {Temperature} degrees.";
    }
}
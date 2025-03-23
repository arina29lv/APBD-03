namespace CargoManager;

public class Ship
{
    private List<Container> containers = new();
    public double MaxSpeed { get; set; }
    public int MaxContainers { get; set; }
    public double MaxWeight { get; set; }

    public Ship(double maxSpeed, int maxContainers, int maxWeight)
    {
        MaxSpeed = maxSpeed;
        MaxContainers = maxContainers;
        MaxWeight = maxWeight;
    }

    public void AddContainer(Container container)
    {
        if(containers.Count >= MaxContainers)
            throw new InvalidOperationException("No space to add more containers.");
        if (containers.Sum(c => c.TareWeight + c.CurrentLoad)
            + container.TareWeight + container.CurrentLoad > MaxWeight)
            throw new InvalidOperationException("Exceeding ships weight limit.");
        containers.Add(container);
    }

    public void RemoveContainer(Container container)
    {
        containers.Remove(container);
    }

    public void TransferContainer(Ship targedShip, Container container)
    {
        RemoveContainer(container);
        targedShip.AddContainer(container);
    }

    public override string ToString()
    {
        double totslWeight = containers.Sum(c => c.TareWeight + c.CurrentLoad);
        return $"SHIP: {containers.Count}/{MaxContainers} containers, {totslWeight}/{MaxWeight} tons; Speed: {MaxSpeed} knots.";
    }
}
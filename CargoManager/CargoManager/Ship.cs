namespace CargoManager;

public class Ship
{
    private List<Container> containers = new();
    public int MaxContainers { get; set; }
    public double MaxWeight { get; set; }

    public Ship(int maxContainers, int maxWeight)
    {
        MaxContainers = maxContainers;
        MaxWeight = maxWeight;
    }

    public void AddContainer(Container container)
    {
        if(containers.Count >= MaxContainers)
            throw new InvalidOperationException("No space to add more containers.");
        containers.Add(container);
    }

    public override string ToString()
    {
        return $"Ship: {containers.Count} / {MaxContainers}";
    }
}
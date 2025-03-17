namespace CargoManager;

public static class SerialNumGenerator
{
    private static int counter = 1;

    public static string Generate(string type)
    {
        return $"KON-{type}-{counter++}";
    }
}
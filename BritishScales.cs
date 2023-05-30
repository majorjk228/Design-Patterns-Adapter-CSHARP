namespace Design_Patterns_Adapter_CSHARP;

public class BritishScales : IScales
{
    private float currentWeight; // текущий вес

    public BritishScales(float cw) => currentWeight = cw;

    public float GetWeight()
    {
        return currentWeight; // Фунты
    }

    public void Adjust() => Console.WriteLine("Регулировка британских весов!");
}
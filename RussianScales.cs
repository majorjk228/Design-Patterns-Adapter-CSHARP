namespace Design_Patterns_Adapter_CSHARP;

public class RussianScales : IScales
{
    private float currentWeight; // текущий вес

    public RussianScales(float cw) => currentWeight = cw;
    
    public float GetWeight()
    {
        return currentWeight;
    }

    public void Adjust() => Console.WriteLine("Регулировка российский весов!");
    
}
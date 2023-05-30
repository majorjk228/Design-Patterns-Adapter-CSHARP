namespace Design_Patterns_Adapter_CSHARP;

public class AdapterForBritishScales : BritishScales, IScales
{
    public AdapterForBritishScales(float cw) : base(cw) {} // принимаем единицу, передаем ее в конструктор базавого класса

    float IScales.GetWeight()
    {
        return base.GetWeight() * .453f; // Вызываем метод из базового класса, умноженного на .453, из фунтов получаем КГ
    }

    void IScales.Adjust()
    {
        base.Adjust();
        Console.Write("  + в методе регулирвоки ADjust() адаптераa");
    }
}
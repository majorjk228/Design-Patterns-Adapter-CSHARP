namespace Design_Patterns_Adapter_CSHARP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IScales rScales = new RussianScales(55.0f); // 55kg

            IScales bScales = new BritishScales(55.0f); // 55funtov

            IScales adapterScales = new AdapterForBritishScales(55.0f); // 55funtov

            Console.WriteLine("Русские весы: " + rScales.GetWeight());
            Console.WriteLine("Британские весы: " + bScales.GetWeight());
            Console.WriteLine("Aдаптер весы: " + adapterScales.GetWeight());

            rScales.Adjust();
            bScales.Adjust();
            adapterScales.Adjust();
        }
    }
}
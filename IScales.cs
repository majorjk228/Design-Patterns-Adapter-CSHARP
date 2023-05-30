namespace Design_Patterns_Adapter_CSHARP;

public interface IScales
{
    float GetWeight(); // Получаем вес

    void Adjust();      // Контроль весов
}
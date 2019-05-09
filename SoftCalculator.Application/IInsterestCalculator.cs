namespace SoftCalculator.Application
{
    public interface IInsterestCalculator
    {
        decimal Calculate(decimal valorInicial, int tempo);
    }
}
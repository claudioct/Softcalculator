namespace SoftCalculator.Application
{
    public interface IInsterestCalculatorService
    {
        decimal Calculate(decimal initialAmount, int months);
    }
}
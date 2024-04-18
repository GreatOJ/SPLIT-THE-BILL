namespace Spiltamountlibrary;
public class TipCalculator
{
    public static decimal CalculateTipPerPerson(decimal price, int numberOfPatrons, float tipPercentage)
    {
        if (numberOfPatrons <= 0)
        {
            throw new ArgumentException("Number of patrons must be greater than zero.");
        }

        decimal totalTip = price * (decimal)(tipPercentage / 100);
        return totalTip / numberOfPatrons;
    }
}

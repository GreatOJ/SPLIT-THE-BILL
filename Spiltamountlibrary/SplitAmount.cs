namespace Spiltamountlibrary;
public class Splitter
{
    public static decimal SplitAmount(decimal amount, int numberOfPeople)
    {
        if (numberOfPeople <= 0)
        {
            throw new ArgumentException("Number of people must be greater than zero.");
        }

        return amount / numberOfPeople;
    }
}
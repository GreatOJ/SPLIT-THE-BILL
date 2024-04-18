namespace Spiltamountlibrary;
public class TipPerPerson
{
    public static Dictionary<string, decimal> CalculateTipPerPerson(Dictionary<string, decimal> mealCosts, float tipPercentage)
    {
        var tipPerPerson = new Dictionary<string, decimal>();

        decimal totalMealCost = 0.0m;
        foreach (var kvp in mealCosts)
        {
            totalMealCost += kvp.Value;
        }

        decimal totalTip = totalMealCost * (decimal)(tipPercentage / 100);

        foreach (var kvp in mealCosts)
        {
            decimal individualTip = kvp.Value / totalMealCost * totalTip;
            tipPerPerson.Add(kvp.Key, individualTip);
        }

        return tipPerPerson;
    }
}
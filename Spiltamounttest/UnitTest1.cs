using Spiltamountlibrary;

namespace Spiltamounttest;

[TestClass]
public class SplitterTests
{
    [TestMethod]
    public void SplitAmount_ReturnsCorrectAmount_WhenValidInputs()
    {
        decimal amount = 100.0m;
        int numberOfPeople = 4;

        decimal result = Splitter.SplitAmount(amount, numberOfPeople);

        Assert.AreEqual(25.0m, result);
    }

    [TestMethod]
    public void SplitAmount_ThrowsArgumentException_WhenNumberOfPeopleIsZero()
    {
        decimal amount = 100.0m;
        int numberOfPeople = 0;

        Assert.ThrowsException<ArgumentException>(() => Splitter.SplitAmount(amount, numberOfPeople));
    }

    [TestMethod]
    public void SplitAmount_ThrowsArgumentException_WhenNumberOfPeopleIsNegative()
    {
        decimal amount = 100.0m;
        int numberOfPeople = -1;

        Assert.ThrowsException<ArgumentException>(() => Splitter.SplitAmount(amount, numberOfPeople));
    }
}
[TestClass]
    public class TipCalculatorTests
    {
        [TestMethod]
        public void CalculateTipPerPerson_ReturnsCorrectTip_WhenValidInputs()
        {
            // Arrange
            decimal price = 100.0m;
            int numberOfPatrons = 5;
            float tipPercentage = 15.0f;

            // Act
            decimal result = TipCalculator.CalculateTipPerPerson(price, numberOfPatrons, tipPercentage);

            // Assert
            Assert.AreEqual(3.0m, result);
        }

        [TestMethod]
        public void CalculateTipPerPerson_ThrowsArgumentException_WhenNumberOfPatronsIsZero()
        {
            // Arrange
            decimal price = 100.0m;
            int numberOfPatrons = 0;
            float tipPercentage = 15.0f;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => TipCalculator.CalculateTipPerPerson(price, numberOfPatrons, tipPercentage));
        }

        [TestMethod]
        public void CalculateTipPerPerson_ThrowsArgumentException_WhenNumberOfPatronsIsNegative()
        {
            // Arrange
            decimal price = 100.0m;
            int numberOfPatrons = -1;
            float tipPercentage = 15.0f;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => TipCalculator.CalculateTipPerPerson(price, numberOfPatrons, tipPercentage));
        }
    }
     [TestClass]
    public class TipPerPersonTests
    {
      [TestMethod]
public void CalculateTipPerPerson_ReturnsEqualTipForEachPerson_WhenMealCostsAreEqual()
{
    // Arrange
    var mealCosts = new Dictionary<string, decimal>
    {
        {"Alice", 30.0m},
        {"Bob", 30.0m},
        {"Charlie", 30.0m}
    };
    float tipPercentage = 15.0f;

    // Act
    var result = TipPerPerson.CalculateTipPerPerson(mealCosts, tipPercentage);

    // Assert
    decimal expectedTip = (30.0m / 90.0m) * 45.0m; 
    decimal tolerance = 0.01m;
    Assert.IsTrue(Math.Abs(result["Alice"] - expectedTip) < tolerance);
    Assert.IsTrue(Math.Abs(result["Bob"] - expectedTip) < tolerance);
    Assert.IsTrue(Math.Abs(result["Charlie"] - expectedTip) < tolerance);
}



        [TestMethod]
         public void CalculateTipPerPerson_ReturnsEmptyDictionary_WhenMealCostsIsEmpty()
        {
    // Arrange
          var mealCosts = new Dictionary<string, decimal>();
          float tipPercentage = 15.0f;

          // Act
           var result = TipPerPerson.CalculateTipPerPerson(mealCosts, tipPercentage);

            // Assert
             Assert.AreEqual(0, result.Count);
         }


        [TestMethod]
        public void CalculateTipPerPerson_ReturnsZeroTip_WhenTipPercentageIsZero()
        {
            // Arrange
            var mealCosts = new Dictionary<string, decimal>
            {
                {"Alice", 30.0m},
                {"Bob", 40.0m},
                {"Charlie", 50.0m}
            };
            float tipPercentage = 0.0f;

            // Act
            var result = TipPerPerson.CalculateTipPerPerson(mealCosts, tipPercentage);

            // Assert
            foreach (var tip in result.Values)
            {
                Assert.AreEqual(0.0m, tip);
            }
        }
    }
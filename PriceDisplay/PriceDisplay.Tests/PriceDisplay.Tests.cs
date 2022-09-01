namespace PriceDisplay.Tests;

public class PriceDisplayTests
{
    [Test]
    public void Setup_Test() {
      Assert.Pass();
    }

    [Test]
    [TestCase("coffee", 4)]
    [TestCase("paper", 2.25)]
    [TestCase("tv", 1999.00)]
    [TestCase("gum", .10)]
    public void GetPriceLabel(String item, double price)
    {
      PriceDisplay priceDisplay = new PriceDisplay();
      String actual = priceDisplay.GetPriceLabel(item, price);
      String expected = String.Format("The price of the {0} is {1}.", item, price);
      Assert.AreEqual(actual, expected);
    }
}
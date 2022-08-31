using System;

namespace PriceDisplay {
  class PriceDisplay {

    static void Main(string[] args){
      string item = "Coffee Machine";
      double price = 15.99;
      new PriceDisplay().DisplayItemPrice(item, price);
    }
    public void DisplayItemPrice(string item, double price){
      Console.WriteLine("The price of the item {0} is {1}.", item, price);
    }
  }

}

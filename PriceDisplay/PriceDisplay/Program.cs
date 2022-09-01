using System;

namespace PriceDisplay {
  public class PriceDisplay {

    static void Main(string[] args){
      // string item = "Coffee Machine";
      // double price = 15.99;
      // new PriceDisplay().DisplayItemPrice(item, price);
    }
    // public void DisplayItemPrice(string item, double price){
    //   Console.WriteLine("The price of the item {0} is {1}.", item, price);
    // }

    public String GetPriceLabel(string item, double price){
      // Console.WriteLine("The price of the item {0} is {1}.", item, price);
      return "The price of the " + item + " is " + price + ".";
    }
  }

}

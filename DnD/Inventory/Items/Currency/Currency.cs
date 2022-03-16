using System;
using System.Collections.Generic;
using System.Linq;


namespace DnD
{
    public class Currency : Item
    {
        // Every type of currency
        public enum CurrencyType
        {
            Copper,
            Silver,
            Electrum,
            Gold,
            Platinum
        }
        
        // Set the default weight of one coin, this is used when encumberence is turned on
        private const double currencyWeight = 0.32;
        
        // Number of coins for this currency
        public int iNumCurrency= 0;
        
        // Default constructor to set what type of currency is being used and the amount of money for that currency
        public Currency(CurrencyType coinType, int iNewNumCurrency)
        {
            // Check to see what coin type was passed
            // Based on the coin type, then set the name of the coin
            switch(coinType)
            {
                case CurrencyType.Copper:
                {
                    setName("Copper Coin(s)");
                    break;
                }
                case CurrencyType.Silver:
                {
                    setName("Silver Coin(s)");
                    break;
                }
                case CurrencyType.Electrum:
                {
                    setName("Electrum Coin(s)");
                    break;
                }
                case CurrencyType.Gold:
                {
                    setName("Gold Coin(s)");
                    break;
                }
                case CurrencyType.Platinum:
                {
                    setName("Platinum Coin(s)");
                    break;
                }
            }
            
            // Set the number of pieces of this currency to the one passed
            iNumCurrency = iNewNumCurrency;
            
            // Set the weight based on the weight of one piece of currency times the total number of pieces pf that currency
            setWeight(currencyWeight * iNumCurrency);
        }
        
        // Get the number of coins of this specific currency
        public int getAmount()
        {
            return iNumCurrency;
        }
        
        // Set the number of coins of this specific currency
        public void SetCurrency(int iNewNumAmount)
        {
            iNumCurrency = iNewNumAmount;
        }
        
        public void printData()
        {
            Console.WriteLine("Name: {0}, Weight: {1}, Amount: {2}", sName, dWeight, iNumCurrency);
        }
    }
}

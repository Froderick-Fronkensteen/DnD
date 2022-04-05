using Xamarin.Forms;
using System;

namespace DnD
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }
        
        public void GetData(object sender, EventArgs args)
        {
             Currency[] Coins = new Currency[5];
             Coins[0] = new Currency(Currency.CurrencyType.Copper, 10);
             Coins[1] = new Currency(Currency.CurrencyType.Silver, 20);
             Coins[2] = new Currency(Currency.CurrencyType.Electrum, 30);
             Coins[3] = new Currency(Currency.CurrencyType.Gold, 40);
             Coins[4] = new Currency(Currency.CurrencyType.Platinum, 50);
             for (int i = 0; i < Coins.Length; i++)
             {
                 Coins[i].printData();
             }
             
             Dice mydice = new Dice(Dice.DiceType.d20);
             
             int[] rollResult = mydice.Roll(4, 0);
             
             for (int i = 0; i < rollResult.Length; i++)
             {
                 Console.WriteLine("Roll ({0}): {1}", i, rollResult[i]);
             }
        }
    }
}

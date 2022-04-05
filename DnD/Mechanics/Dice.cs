using System;
using System.Collections.Generic;
using System.Linq;

namespace DnD
{
    public class Dice
    {
        // Types of dice in the D20 system
        public enum DiceType
        {
            d4,
            d6,
            d8,
            d10,
            d12,
            d20,
            d100
        }
        
        // Type of dice picked from DiceType before
        private DiceType currentDice;
        
        // Array to hold all dice roll results
        private int[] rollHistory;
        
        // Result of all dice rolls plus the modifier if it is specified
        private int rollTotal;
        
        // Constructor to assign what type if dice this is
        public Dice(DiceType newDice)
        {
            // Set the dice type based on what is passed to the function
            currentDice = newDice;
        }
        
        // Roll a specific number of dice, record the results, and return back to caller
        public int[] Roll(int numDiceToRoll, int rollModifier)
        {
            // Check to make sure numDiceToRoll is not <= 0
            if (numDiceToRoll <= 0)
            {
                numDiceToRoll = 1;
            }
            
            // Create new random object
            Random rnd = new Random();
            
            // Check to see if the roll modifier is supplied and is <= 0
            if (rollModifier <= 0)
            {
                rollHistory = new int[numDiceToRoll];
            }
            else
            {
                // If the roll modifier > 0 then increase the number of objects in the array by 1
                // This is to hold the number of the modifier supplied to the function, this shows the user how the total was calculated
                rollHistory = new int[numDiceToRoll+1];
            }
            
            // Create a variable to hold the max number that should be capable in the random.next() function
            int maxRandomNum = 0;
            
            //  Check to see the DiceType supplied to determine the max number of the random.next() function
            switch(currentDice)
            {
                case DiceType.d4:
                {
                    maxRandomNum = 5;
                    
                    break;
                }
                case DiceType.d6:
                {
                    maxRandomNum = 7;
                    
                    break;
                }
                case DiceType.d8:
                {
                    maxRandomNum = 9;
                    
                    break;
                }
                case DiceType.d10:
                {
                    maxRandomNum = 11;
                    
                    break;
                }
                case DiceType.d12:
                {
                    maxRandomNum = 13;
                    
                    break;
                }
                case DiceType.d20:
                {
                    maxRandomNum = 21;
                    
                    break;
                }
                case DiceType.d100:
                {
                    maxRandomNum = 101;
                    break;
                }
            }
            
            // Loop through the number of dice we have to roll
            for (int i = 0; i < numDiceToRoll; i++)
            {
                // Get a random number between 1 and the maxRandomNum set above
                int currentRoll = rnd.Next(1,maxRandomNum);
                
                // Store this roll in the rollHistory array
                rollHistory[i] = currentRoll;
                
                // Add the current roll to the total of all the previous rolls
                rollTotal += currentRoll;
            }
            
            // Check to see if the modifier supplied is greater than 0
            if (rollModifier > 0)
            {
                // Store the modifier at the end of the rollHistory array
                rollHistory[rollHistory.Length - 1] = rollModifier;
                
                // Add the modifier to the roll total
                rollTotal += rollModifier;
            }
            
            // Return the rollHistory variable to the caller            
            return rollHistory;
        }
        
        // Another Roll function that is used to roll d20 dice with advantage or disadvantage based on rollWithAdvantage        
        public int Roll(bool rollWithAdvantage)
        {
            // Create a new random object
            Random rnd = new Random();
            
            // Get a random number between 1-20 and store it for the first roll
            int firstRoll = rnd.Next(1,21);
            
            // Get a random number between 1-20 and store it for the second roll
            int secondRoll = rnd.Next(1,21);
            
            // Check to see if rollWithAdvantage is true, but if it is false than go to the else statement
            if (rollWithAdvantage)
            {
                // If rollWithAdvantage is true we need to check both rolls and only return the higher one else if it is false we return the lower one
                
                // If the first roll is greater than the second then return the first roll, if not the  return the second roll              
                if (firstRoll >= secondRoll)
                {
                    return firstRoll;
                }
                else
                {
                    return secondRoll;
                }
            }
            else
            {
                // If rollWithAdvantage is false then this section will run and check which roll is the lowest and return it to the caller
                if (firstRoll <= secondRoll)
                {
                    return firstRoll;
                }
                else
                {
                    return secondRoll;
                }
            }
        }
        
        // Returns the total of all the dice rolls and the modifier if it is supplied
        public int getRollTotal()
        {
            return rollTotal;
        }
    }
}


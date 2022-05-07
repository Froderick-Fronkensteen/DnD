using System;
using System.Collections.Generic;
using System.Linq;


namespace DnD
{
    public class Item
    {
        // Name of the item
        protected string sName;
        
        // Cost of the item
        protected Currency iCost;
        
        // Weight of the item (in ounces)
        protected double dWeight;
        
        // Get the name of the item
        public string getName()
        {
            return sName;
        }
        
        // Set the name of the item
        public void setName(string newName)
        {
            sName = newName;
        }
        
        // Get the weight of the item
        public double getWeight()
        {
            return dWeight;
        }
        
        // Get the weight but get it in string format
        public string getWeightString()
        {
            return dWeight.ToString();
        }
        
        // Set the weight of the item
        public void setWeight(double newWeight)
        {
            dWeight = newWeight;
        }

        // Get the cost of the item
        public Currency getCost()
        {
            return iCost;
        }

        // Set the cost of the item
        public void setCost(Currency newCost)
        {
            iCost = newCost;
        }
    }
}

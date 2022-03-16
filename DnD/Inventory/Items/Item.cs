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
        protected int iCost;
        
        // Weight of the item (in ounces)
        protected double dWeight;
        
        public string getName()
        {
            return sName;
        }
        
        public void setName(string newName)
        {
            sName = newName;
        }
        
        public double getWeight()
        {
            return dWeight;
        }
        
        public string getWeightString()
        {
            return dWeight.ToString();
        }
        
        public void setWeight(double newWeight)
        {
            dWeight = newWeight;
        }
    }
}

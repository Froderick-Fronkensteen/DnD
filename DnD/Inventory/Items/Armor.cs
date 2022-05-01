using System;
using System.Collections.Generic;
using System.Linq;


namespace DnD.Inventory.Items
{
    public class Armor : Item
    {
        // Time it takes to put armor and take armor off
        private enum DonDoffTime
        {
            OneMinute,
            FiveMinutes,
            TenMinutes,
            OneAction
        }

        // Type of Armor
        private enum ArmorType
        {
            Light,
            Medium,
            Heavy,
            Shield
        }

        // Time it takes to put armor on
        int don = 0;
        
        // Time it takes to take armor off
        int doff = 0;

        // Type of armor
        ArmorType armorType = null;
        
        // Armor Class
        int armorClass = 0;

        // Should we add the dexterity modifer to the armor
        bool addDexMod = false;

        // If we do use the dexterity modifer for the armor does it have a max amount?
        int maxDexMod = 0;

        // Strength requirement to wear the armor (must be >= not to reduce speed by 10 ft)
        int strRequirement = 0;

        // Does the armor give disadvantage on dexterity (stealth) checks
        bool hasStealthDisadvantage = false;

        // Constructor to load to new armor
        public Armor(ArmorType newArmorType, string newArmorName, int armorCost, int newArmorClass, bool newAddDexMod, int newMaxDexMod, int newStrRequirement, bool newHasStealthDisadvantage, int newArmorWeight)
        {
            armorType = newArmorType;
            setName(newArmorName);
            setCost(armorCost);
            armorClass = newArmorClass;
            addDexMod = newAddDexMod;
            maxDexMod = newMaxDexMod;
            strRequirement = newStrRequirement;
            hasStealthDisadvantage = newHasStealthDisadvantage;
            setWeight(newArmorWeight);
        }

        // Get the type of armor this is
        public ArmorType getArmorType()
        {
            return armorType;
        }

        // Get the Armor Class (AC) number
        public int getArmorClass()
        {
            // TODO find a way to also grab the Dexterity Modifier and add to the armor
            // Class if the addDexMod is set to true, if not just return the base AC
            return armorClass;
        }

        // Get if the armor has a specific strength requirement to wear it without
        // slowing down your speed
        public int getStrengthRequirement()
        {
            return strRequirement;
        }

        // Check to see if the armor gives disadvantage Dexterity (Stealth) checks
        public bool getStealthDisadvantage()
        {
            return hasStealthDisadvantage;
        }
    }
}

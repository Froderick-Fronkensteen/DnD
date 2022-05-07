using System;
using System.Collections.Generic;
using System.Linq;


namespace DnD.Inventory.Items
{
    public class Weapon : Item
    {
        private enum WeaponType
        {
            Simple_Melee,
            Simple_Ranged,
            Martial_Melee,
            Martial_Ranged
        }

        private enum DamageType
        {
            Bludgeoning,
            Piercing,
            Slashing
        }

        private WeaponType weaponType = null;

        private Dice damageDice = null;

        private DamageType damageType = null;

        private string weaponProperties = null;

        public Weapon (WeaponType newWeaponType, string newWeaponName, Currency newWeaponCost, Dice newDamageDice, DamageType newDamageType, int newWeaponWeight, string newWeaponProperties)
        {
            weaponType = newWeaponType;
            setName(newWeaponName);
            setCost(newWeaponCost);
            damageDice = newDamageDice;
            damageType = newDamageType;
            setWeight(newWeaponWeight);
            weaponProperties = newWeaponProperties;
        }

        public int DamageRoll()
        {
            return damageDice.Roll(0);
        }

        public WeaponType getWeaponType()
        {
            return weaponType;
        }

        public Dice getDamageDice()
        {
            return damageDice;
        }

        public DamageType getDamageType()
        {
            return damageType;
        }

        public string getWeaponProperties()
        {
            return weaponProperties;
        }
    }
}

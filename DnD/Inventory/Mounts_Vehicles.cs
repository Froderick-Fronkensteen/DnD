using System;
using System.Collections.Generic;
using System.Linq;


namespace DnD.Inventory
{
    public class Mounts_Vehicles : Item
    {
        // How fast can the mount or vehicle move
        int speed = 0;
        
        // How much weight the mount or vehicle can carry
        int carryingCapacity = 0;
        
        public Mounts_Vehicles(string name, Currency cost, int newSpeed, int newCarryingCapacity)
        {
            setName(name);
            setCost(cost);
            speed = newSpeed;
            carryingCapacity = newCarryingCapacity;
        }
        
        // Get the speed of the mount or vehicle
        public int getSpeed()
        {
            return speed;
        }
        
        // Get the carrying capacity of the mount or vehicle
        public int getCarryingCapacity()
        {
            return carryingCapacity;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Math_Library;

namespace Console_Jam
{
    class Player : Entity
    {
        private Item[] _inventory;
        private Item _currentItem;
        private int _currentItemIndex;
        private Item[] _equippedItems;

        public override float Health
        {
            get { return _health; }
        }

        // Gets the player's attack based on if they have equipment or not.
        public override float AttackPower
        {
            get
            {
                if (_equippedItems[0].Name != "Nothing")
                {
                    return base.AttackPower + _equippedItems[0].StatBoost;
                }

                return base.AttackPower;
            }
        }

        // Gets the player's defense based on if they have equipment or not.
        public override float DefensePower
        {
            get
            {
                if (_equippedItems[1].Name != "Nothing")
                {
                    return base.DefensePower + _equippedItems[1].StatBoost;
                }

                return base.DefensePower;
            }
        }

        public Player(float health, float attackPower, float defensePower, char icon, Vector2 position, string name) 
            : base(health, attackPower, defensePower, icon, position, name)
        {
            _inventory = new Item[0];
            _equippedItems = new Item[2];
        }

        /// <summary>
        /// Attempts to equip an item of an index given to us by the user.
        /// </summary>
        /// <param name="index"> The index which refers to an item. </param>
        /// <returns> If the user can equip the item or not. </returns>
        public bool TryEquipItem(int index)
        {
            // Checks to see if the index is out of bounds of our _items array. If it is...
            if (index >= _inventory.Length || index < 0)
            {
                // ...it returns false.
                _currentItemIndex = -1;
                return false;
            }

            // Updates currentItemIndex to be equal to the given index.
            _currentItemIndex = index;

            // Sets the current item to the item at the index.
            _currentItem = _inventory[_currentItemIndex];

            // If the item boosts attack...
            if (_currentItem.ItemType == BoostType.ATTACK)
            {
                // ...it is set to the first index of equipped items.
                _equippedItems[0] = _currentItem;
            }
            // If the item boosts defense...
            else if (_currentItem.ItemType == BoostType.DEFENSE)
            {
                // ...it is set to the second index of equipped items.
                _equippedItems[1] = _currentItem;
            }

            return true;
        }

        /// <summary>
        /// Sets the current items to nothing.
        /// </summary>
        /// <returns> Whether or not the player already had an item equipped. </returns>
        public bool TryUnequipItem()
        {
            // Checks to see if anything is equipped. If it is...
            if (_equippedItems[0].Name == "Nothing" && _equippedItems[1].Name == "Nothing")
            {
                // ...it returns false.
                return false;
            }

            _currentItemIndex = -1;

            // Sets the items to nothing.
            _equippedItems[0] = new Item();
            _equippedItems[0].Name = "Nothing";
            _equippedItems[1] = new Item();
            _equippedItems[1].Name = "Nothing";

            return true;
        }

        /// <summary>
        /// Allows the player to eat the weapon they currently have equipped in order to regain health, but it heavily decrements
        /// the item's durability.
        /// </summary>
        /// <param name="equippedItem"> The equipped item chosen to be eaten. </param>
        public void EatWeapon(Item equippedItem)
        {
            // Decrements the equippedItem's durability.
            equippedItem.Durability -= 10;

            // Adds the stat boost of the item to the player's health.
            _health += equippedItem.StatBoost;
            Console.WriteLine("You recovered " + _currentItem.StatBoost + " health!");
            Console.ReadKey(true);
            Console.Clear();

            // If the item's durability is zero, or below zero...
            if (equippedItem.Durability >= 0)
            {
                // ...break the item.
                BreakItem(equippedItem);
            }
        }

        /// <summary>
        /// Removes the chosen item from the player's inventory and removes it from their equipped items.
        /// </summary>
        /// <param name="equippedItem"> The equipped item being removed. </param>
        public void BreakItem(Item equippedItem)
        {
            // Creates a new list for the player's inventory.
            Item[] newInventory = new Item[_inventory.Length - 1];

            int j = 0;

            bool itemRemoved = false;

            // Removes the item from the player's inventory.
            for (int i = 0; i < _inventory.Length; i++)
            {
                // If the current item's ID is not the same as the equipped item's ID, or an item of the same type has been 
                // removed before...
                if (_inventory[i].ItemID != equippedItem.ItemID || itemRemoved)
                {
                    // ...it sets the current item in inventory to the current item in the newInventory.
                    newInventory[j] = _inventory[i];
                    j++;
                }
                // If the ID's match and an item of the same type has not been removed before.
                else
                {
                    // ...it sets itemRemoved to true. And keeps the item from being added to the newInventory.
                    itemRemoved = true;
                }
            }

            // Sets the old inventory equal to the new one.
            _inventory = newInventory;

            // Removes the item from the player's equipped items.
            for(int i = 0; i < _equippedItems.Length; i++)
            {
                if (_equippedItems[i].ItemID == equippedItem.ItemID)
                {
                    _equippedItems[i] = new Item();
                    _equippedItems[i].Name = "Nothing";
                }
            }

            // Lets the player know the item broke.
            Console.WriteLine(equippedItem.Name + " broke!");
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}

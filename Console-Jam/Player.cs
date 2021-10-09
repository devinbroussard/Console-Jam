using System;
using System.Collections.Generic;
using System.Text;
using Math_Library;

namespace Console_Jam
{
    class Player : Entity
    {
        private Item[] _inventory;
        private int _currentItem;
        private Item[] _equippedItems;

        public Player(float health, float attackPower, float defensePower, char icon, Vector2 position, string name) 
            : base(health, attackPower, defensePower, icon, position, name)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Math_Library;

namespace Console_Jam
{
    class Entity : Actor
    {
        protected float _health;
        private float _attackPower;
        private float _defensePower;
        
        public virtual float Health
        {
            get { return _health; }
        }

        public virtual float AttackPower
        {
            get { return _attackPower; }
        }

        public virtual float DefensePower
        {
            get { return _defensePower; }
        }

        public Entity(float health, float attackPower, float defensePower, char icon, Vector2 position, string name) 
            : base(icon, position, name)
        {
            _health = health;
            _attackPower = attackPower;
            _defensePower = defensePower;
        }

        /// <summary>
        /// Allows the entity to take damage and decrease their health based on that damage.
        /// </summary>
        /// <param name="damageAmount"> The amount of damage being dealt. </param>
        /// <returns> The amount of damage being dealt. </returns>
        public float TakeDamage(float damageAmount)
        {
            // Gets the amount of damage being dealt to the entity.
            float damageTaken = damageAmount - DefensePower;

            // If the damage being taken is less than zero...
            if (damageTaken < 0)
            {
                // ...it sets it equal to zero.
                damageTaken = 0;
            }

            _health -= damageTaken;

            Console.WriteLine(Name + " took " + damageTaken + " damage!");
            Console.ReadKey(true);
            Console.Clear();

            return damageTaken;
        }

        /// <summary>
        /// This entity will attack another entity, dealing damage to it.
        /// </summary>
        /// <param name="defender"> The target of the attack. </param>
        /// <returns> It will return the damage that is being taken. </returns>
        public float Attack(Entity defender)
        {
            return defender.TakeDamage(AttackPower);
        }
    }
}

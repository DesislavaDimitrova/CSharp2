using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Game
{
    internal class Unit
    {
        private int maxHealth;
        private int currentHealth;
        private int power;
        private int heal;
        private string unitName;
        private Random random;

        public int Health { get { return currentHealth; } }
        public string UnitName { get { return unitName; } }

        public bool IsDead {  get { return currentHealth <= 0; } }




        public Unit(int maxHealth, int power, int heal, string unitName)
        {
            this.maxHealth = maxHealth;
            this.currentHealth = maxHealth;
            this.power = power;
            this.heal = heal;
            this.unitName = unitName;
            this.random = new Random();
            
        }

        public void Attack(Unit unitToAttack)
        {
            double rng = random.NextDouble();
            rng = rng / 2 + 0.75f;
            int rndDamage = (int)(power * rng);
            unitToAttack.TakeDamage(rndDamage);
            Console.WriteLine($"{UnitName} took {rndDamage} health points from {unitToAttack.unitName}");
        }

        void TakeDamage(int damage)
        {
            currentHealth -= damage;
            if (IsDead)
            {
                Console.WriteLine($"{UnitName} is dead!");
            }
        }

        public void Heal()
        {
            double rng = random.NextDouble();
            rng = rng / 2 + 0.75f;
            int healPoints = (int)(heal * rng);
            currentHealth = currentHealth + healPoints > maxHealth ? maxHealth: healPoints;
        }



    }
}

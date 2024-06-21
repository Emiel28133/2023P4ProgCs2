using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class ConsoleMon
    {
        public int health { get; set; }
        public int energy { get; set; }
        public string name { get; set; }
        public Skill skills;
        public Element weakness;

        public void TakeDamage(int damage)
        {
            health = health - damage;
        }

        public void DepleteEnergy(int energy)
        {
            this.energy -= energy;
        }
    }
}

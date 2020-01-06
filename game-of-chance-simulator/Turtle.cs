using System;
namespace GameOfChanceSimulator
{
    public class Turtle
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Crit { get; set; }

        public Turtle(string health,string damage,string crit)
        {
            this.Health = Convert.ToInt32(health);
            this.Damage = Convert.ToInt32(damage);
            this.Crit = Convert.ToInt32(crit);
        }

    }
}

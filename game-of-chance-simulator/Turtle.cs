using System;
namespace GameOfChanceSimulator
{
    public class Turtle
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public float Crit { get; set; }

        public Turtle(int health,int damage,float crit)
        {
            this.Health = health;
            this.Damage = damage;
            this.Crit = crit;
        }

    }
}

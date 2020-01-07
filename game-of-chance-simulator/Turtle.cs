using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
namespace GameOfChanceSimulator
{
    public class Turtle
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Crit { get; set; }


        public Turtle(string name, int health, int damage, int crit)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
            this.Crit = crit;
        }

        

    }
}

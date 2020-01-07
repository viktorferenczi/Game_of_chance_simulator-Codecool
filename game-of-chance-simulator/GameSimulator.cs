using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GameOfChanceSimulator
{
    public class GameSimulator
    {
        public string Simulator()
        {
            string[] turtlelines = File.ReadAllLines("turtle.csv");
            List<string> datas;
            List<Turtle> turtles = new List<Turtle>();


            for (int i = 0; i < turtlelines.Length; i++)
            {
                List<string> data = new List<string>();
                data.Add(turtlelines[i]);
                for (int j = 0; j < data.Count; j++)
                {
                    datas = data[j].Split(',').ToList();
                    Turtle turtos;
                    turtos = new Turtle(datas[0], Convert.ToInt32(datas[1]), Convert.ToInt32(datas[2]), Convert.ToInt32(datas[3]));
                    turtles.Add(turtos);
                }

            }
            Random rnd = new Random();




            void Attack(int Attacker, int Attacked)
            {
                if (rnd.Next(0, 100) < turtles[Attacker].Crit)
                {
                    turtles[Attacked].Health -= 200;
                }
                else
                {
                    turtles[Attacked].Health -= 100;
                }

            }

          

             bool AllDead()
            {
                int counter = 0;
                for (int i = 0; i < turtles.Count; i++)
                {
                    if (turtles[i].Health <= 0)
                    {
                        counter += 1;
                    }
                }
                if (counter == 4)
                {
                    
                    return true;
                }
                else
                {
                    return false;
                }

            }

            bool NotDeadenemy(int number)
            {

                if (turtles[number].Health <= 0)
                {
                    return false;
                }
                return true;
            }

            bool ChooseYourself(int number)
            {
                if (number.Equals(turtles[number]))
                {
                    return true;
                }
                return false;
            }

            bool NotDeadYourself(int i)
            {

                if (turtles[i].Health <= 0)
                {
                    return false;
                }
                return true;
            }

          //  string ReturnWinner()
           // {
            //    for (int i = 0; i < turtles.Capacity; i++)
             //   {
              //      if (turtles[i].Health > 0)
              //      {
               //         return turtles[i].Name;
               //     }
                   
              //  }
          //  }

            AllDead(); // setting AllDead to false

            while (AllDead() == false) // doing this while there is more than 1 alive turtle
            {

                for (int attacker = 0; attacker < turtles.Count; attacker++) // 5 hit for 5 attacker
                {
                    if (NotDeadYourself(attacker) == true) // if the attacker is not dead
                    {
                        while (true) // this while loop: trying to attack, but if he can't he will choose a new opponent
                        {
                            int enemy = rnd.Next(0, turtles.Count); // generate an enemy

                            if (NotDeadYourself(attacker) == true) // if the attacker is not dead
                            {
                                if (NotDeadenemy(enemy) == true && ChooseYourself(attacker) == false) // if the enemy is not dead and the attacker is not choosing himself
                                {
                                    Attack(attacker, enemy); // attacker hits the enemy
                                    AllDead(); // checking if everybody is dead except one guy
                                    break; // forloop iterating for the next attacker
                                }
                            }
                            continue; // this attacker try to attack again.
                        }

                    }
                  
               
                }

            }

            for (int i = 0; i < turtles.Count; i++)
            {
                if (turtles[i].Health > 0)
                {
                    return turtles[i].Name;
                }

            }
            throw new InvalidOperationException("asd");
        }

     }

 }  


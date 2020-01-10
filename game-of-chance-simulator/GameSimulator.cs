using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GameOfChanceSimulator
{
    public class GameSimulator
    { 
        public List<string> Simulator()
        {
            // getting data from csv, then put the fighter objects in a list
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
            


            Random rnd = new Random(); // random generator for enemy




            void Attack(int Attacker, int Attacked) 
            {
                // ATTACK!!!!!!
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
                // check how many dead turtle in the game
                int counter = 0;
                for (int i = 0; i < turtles.Count; i++)
                {
                    if (turtles[i].Health <= 0)
                    {
                        counter += 1;
                    }
                }
                if (counter == turtles.Count-1)
                {
                    
                    return true;
                }
                else
                {
                    return false;
                }

            }

            bool NotDeadEnemy(int number) 
            {
                // check if the enemy is alive or not
                if (turtles[number].Health <= 0)
                {
                    return false;
                }
                return true;
            }

            

            bool NotDeadYourself(int i) 
            {
                // check if the attacker is alive
                if (turtles[i].Health <= 0)
                {
                    return false;
                }
                return true;
            }

         

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

                                if (NotDeadEnemy(enemy) == true && attacker != enemy) // if the enemy is not dead and the attacker is not choosing himself
                                {
                                    Attack(attacker, enemy); // attacker hits the enemy
                                    DiedByRanks(); //check who died recently
                                    AllDead(); // checking if everybody is dead except one guy
                                    break; // forloop iterating for the next attacker
                                }
                           
                            break; // this attacker try to attack again.
                        }

                    }
                  
               
                }

            }
            List<string> Listbackward()
            {
                // getting list backward
                List<string> lista = new List<string>();
                lista = DiedByRanks();
                for (int i = 0; i < turtles.Count; i++)
                {
                    if (turtles[i].Health > 0)
                    {
                        lista.Add(turtles[i].Name);
                    }

                }
                lista.Reverse();
                return lista;
            }

            List<string> DiedByRanks()
            {
                // getting the list of the turtles by death
                List<string> datas = new List<string>();
                for(int i = 0;i < turtles.Count;i++)
                {
                    if(turtles[i].Health <= 0 && !datas.Contains(turtles[i].Name))
                    {
                        datas.Add(turtles[i].Name);
                    }
                }
                return datas;
            }
            return Listbackward();
            
        }

     }

 }  


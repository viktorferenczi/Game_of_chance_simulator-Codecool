using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace GameOfChanceSimulator
{
    public class GameSimulator
    {
        public GameSimulator()
        {
            string[] turtlelines = File.ReadAllLines("turtle.csv");
            List<string> datas;
            List <Turtle> turtles = new List<Turtle>();


            for (int i=0;i<turtlelines.Length;i++)
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
            bool allDead = true;
            while(allDead)
            {
                
                for(int i =0;i<turtles.Count;i++)
                {
                    if(NotDeadYourself(i))
                    {
                        Random rnd = new Random();
                        int number = rnd.Next(0, turtles.Count - 1);
                        while ()
                        {
                            if (NotDeadenemy(number) && ChooseYourself(number))
                            {
                                if (Attack)
                                {
                                    turtles[0];
                                }
                                else
                                {

                                }
                            }
                        }
                        i++;
                    }
                }   
            }

            bool AllDead()
            {
                int counter = 0;
                for (int i = 0; i < turtles.Count; i++)
                {
                    if (turtles[i].Health == 0)
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
                    return true;
                }
                return false;
            }

            bool ChooseYourself(int number)
            {
                if (number == turtles[number])
                {
                    return false;
                }
                return true;
            }

            bool NotDeadYourself(int i)
            {

                if (turtles[i].Health <= 0)
                {
                    return true;
                }
                return false;
            }






        }

    }  
}

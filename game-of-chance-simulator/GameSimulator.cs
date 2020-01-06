using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GameOfChanceSimulator
{
    public class GameSimulator
    {
        

        public static void Simulator()
            {
            var reader = new StreamReader(File.OpenRead("/Users/macbook/Desktop/tw1/game-of-chance-simulator/turtle.csv"));
            List<string> DataList = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                DataList.Add(line);
            }

           
          


            Turtle Jozsika = new Turtle(DataList[1], DataList[2], DataList[3]);
            Turtle Donatello = new Turtle(DataList[5], DataList[6], DataList[7]);
            Turtle Leonardo = new Turtle(DataList[9], DataList[10], DataList[11]);
            Turtle Jani = new Turtle(DataList[13], DataList[14], DataList[15]);
            Turtle Raffaelo = new Turtle(DataList[17], DataList[18], DataList[19]);

            Turtle[] Turtles = { Jozsika, Donatello, Leonardo, Jani, Raffaelo };
            

            Random rnd = new Random();
            while (Turtles.Length>1)
            {
                int Jozsikacrit = rnd.Next(1, 2);
                int JozsikaOpponent = rnd.Next(1, 5);
                Console.WriteLine(Turtles[JozsikaOpponent].Health);
                if (Turtles[JozsikaOpponent].Health > 0)
                {
                    if (Jozsikacrit == 1) // Jozsika have a crit
                    {
                        Turtles[JozsikaOpponent].Health -= 200;
                        Console.WriteLine(Turtles[JozsikaOpponent].Health);
                    }
                    else
                    {
                        Turtles[JozsikaOpponent].Health -= 100;
                        Console.WriteLine(Turtles[JozsikaOpponent].Health);
                    }
                }
                else
                {

                }
                   
              
                
            }





        }
    }
}

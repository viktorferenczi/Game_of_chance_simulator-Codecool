using System;
using System.Collections.Generic;
using System.Linq;

namespace GameOfChanceSimulator
{
    public class HistoricalDataPoint
    {


        public string Storinglist {get;set;}
        /* it could store the names of the horses that participated in a race
        and the order that they've finished after the race. */

        public string winner { get; set; } // store the winner

        public HistoricalDataPoint(List<string> SimulationResult)
        {
            // Generate data from a list
            string jaja="";
            for (int i = 0; i < SimulationResult.Count; i++)
            {
                jaja += SimulationResult[i] + ",";
                this.Storinglist = jaja;
            }
       //     this.Storinglist = $"{SimulationResult[0]},{SimulationResult[1]}," +
       //       $"{SimulationResult[2]},{SimulationResult[3]},{SimulationResult[4]}";
            this.winner = SimulationResult[0];
        }

        public HistoricalDataPoint(string Data)
        {
            // same as the upper constructor just with string
            this.Storinglist = Data;
            string[] SimulationResult = Data.Split(",");
            this.winner = SimulationResult[0];

        }

        public string GetWinner()
        {
            return this.winner;
        }

       
    }
}

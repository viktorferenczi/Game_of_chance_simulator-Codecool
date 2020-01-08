using System;
using System.Collections.Generic;

namespace GameOfChanceSimulator
{
    public class HistoricalDataPoint
    {


        public string Storinglist {get;set;}
        /* it could store the names of the horses that participated in a race
        and the order that they've finished after the race. */

        string winner { get; set; } // store the winner

        public HistoricalDataPoint(List<string> SimulationResult)
        {
            this.Storinglist = $"{SimulationResult[0]},{SimulationResult[1]}," +
                $"{SimulationResult[2]},{SimulationResult[3]},{SimulationResult[4]}";
            this.winner = SimulationResult[0];
        }

        public HistoricalDataPoint(string Data)
        {
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

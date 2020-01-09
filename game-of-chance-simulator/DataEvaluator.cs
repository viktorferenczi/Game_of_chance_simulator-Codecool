using System;
using System.Collections.Generic;
using System.Linq;

namespace GameOfChanceSimulator
{
    public class DataEvaluator
    {
        public DataEvaluator(HistoricalDataSet DataSet,ILogger logger)
        {
            var Result = Run(DataSet);
            logger.Info("Number of Simulations: " + Result.NumberOfSimulations + ". \n");
            logger.Info("Your best choice would be: " + Result.BestChoice + "! (S)he has a winrate of " + Result.BestChoiceChance * 100 + "%.\n");

        }

       

        public Result Run(HistoricalDataSet data)
        {
            int Simulations = data.Datapoints.Count;
            var Winners = new Dictionary<string, int>();
            for (int i = 0; i < Simulations; i++)
            {
                var WinnerList = data.Datapoints[i].GetWinner();
                if (!Winners.ContainsKey(WinnerList))
                {
                    Winners[WinnerList] = 1;
                }
                else if(Winners.ContainsKey(WinnerList))
                {
                    Winners[WinnerList]++;
                }

            }
            var BestChoiceForWin = Winners.Keys.Max();
            float ChanceForBestChoice = (float)Winners[BestChoiceForWin] / (float)Simulations;
            Result final = new Result(Simulations, BestChoiceForWin, ChanceForBestChoice);
                return final;
        }  
    }
}


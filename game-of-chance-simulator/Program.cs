using System;
using System.Linq;

namespace GameOfChanceSimulator
{
    class Program
    {

        static ConsoleLogger logger = new ConsoleLogger();
        static HistoricalDataSet data = new HistoricalDataSet(logger);

        static HistoricalDataSet GenerateHistoricalDataSet(int NumberofSimulations)
        {
            /* alling the method generates historical data (as many rounds as the rounds parameter specifies) or
            if the parameter's value is 0 it loads existing data from a file called history.csv. */

            if (NumberofSimulations.Equals(0))
            {
                data.Load();
                logger.Info("Using already generated data stored in the file...\n");
                for (int i = 0; i < data.Datapoints.Count; i++)
                {
                    logger.Info("Turtle massacre. Winner: " + data.Datapoints[i].winner);
                }
               DataEvaluator Evaulating = new DataEvaluator(data, logger);
                Evaulating.Run(data);
                return data;
            }
            else
            {
                
                for (int j = 0; j < NumberofSimulations; j++)
                {
                    
                    data.Generate();
                    logger.Info("Turtle massacre. Winner: " + data.Datapoints[j].winner);
                }
                DataEvaluator Evaulating = new DataEvaluator(data, logger);
                Evaulating.Run(data);
                return data;
            }

        }

        static void Main(string[] args)
        {
            string result = "showresult";
            try
            {
                if (args.Length == 0)
                {
                    logger.Error("Oops an Error Occurred!\nPlease use: \nnumbers to generate matches \nor \n'showresult' command to see the generated results.");
                }
                else if (Convert.ToInt32(args[0]) < 3)
                {
                    logger.Error("Oops an Error Occurred!\nPlease enter a number, greater than 2 to generate a result.");
                }
                
                else
                {
                    GenerateHistoricalDataSet(Convert.ToInt32(args[0]));
                }
            }
            catch (Exception ex)
            {
                if (args[0].Equals(result))
                {
                    GenerateHistoricalDataSet(0);
                }
                else
                {
                    logger.Error("Oops an Error Occurred!\nPlease use: \nnumbers to generate matches \nor \n'showresult' command to see the generated results.");
                }
            }
            
        }
    }
}


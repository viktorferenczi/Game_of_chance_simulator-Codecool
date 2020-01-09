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
                var Evaulating = new DataEvaluator(data, logger);
                return data;
            }
            else
            {
                data.Load();
                for (int j = 0; j < NumberofSimulations; j++)
                {
                    logger.Info("Turtle massacre. Winner: " + data.Datapoints[j].winner);
                }
                var Evaulating = new DataEvaluator(data, logger);
                return data;
            }

        }

        static void Main(string[] args)
        {
            if (args.Length == 0 || Convert.ToInt32(args[0]).Equals(0))
            {
                GenerateHistoricalDataSet(0);
            }
            else
            {
                GenerateHistoricalDataSet(Convert.ToInt32(args[0]));
            }
        }
    }
}


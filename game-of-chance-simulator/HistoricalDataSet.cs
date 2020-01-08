using System;
using System.Collections.Generic;
using System.IO;

namespace GameOfChanceSimulator
{
    public class HistoricalDataSet
    {
        GameSimulator game = new GameSimulator();
        public int Size { get; private set; } // read-only property to expose the number of the underlying data
        private List<HistoricalDataPoint> __DataPoints;
        public IReadOnlyList<HistoricalDataPoint> Datapoints { get { return __DataPoints.AsReadOnly(); } }

        internal void AddDataPoint(HistoricalDataPoint data)
        {
            __DataPoints.Add(data);
        }

        public HistoricalDataSet(ILogger logger)
        {

            logger.Info("The turtles are: ");
            foreach (var turtle in game.Simulator())
            {
                logger.Info("turtle");
            }
            logger.Info("");
        }

        void Generate()
        {

            /* calling the method generates a single new (randomized) HistoricalDataPoint instance,
             * it adds this to the list of available DataPoints
             * stored by the class and finally appends a new entry to history.csv. */

            HistoricalDataPoint data = new HistoricalDataPoint(game.Simulator());
            AddDataPoint(data);
            Size++;

            string file = @"/Users/macbook/Desktop/tw1/game-of-chance-simulator/history.csv";

            if (!File.Exists(file))
            {
                File.WriteAllText(file, data.Storinglist + "\n");
            }
            else
            {
                File.AppendAllText(file, data.Storinglist + "\n");
            }

        }





        public void Load()
        {
            string file = @"/Users/macbook/Desktop/tw1/game-of-chance-simulator/history.csv";
            string[] data = File.ReadAllLines(file);

            foreach (var item in data)
            {
                HistoricalDataPoint DataFollowup = new HistoricalDataPoint(item);
                AddDataPoint(DataFollowup);
                Size++;
            }
            /* calling the method reads already generated data points from history.csv,
             * it creates an instance of HistoricalDataPoint for each entry in the CSV file. */
        }
    }
}

    


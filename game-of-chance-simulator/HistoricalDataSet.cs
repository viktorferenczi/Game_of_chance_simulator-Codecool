using System;
using System.Collections.Generic;

namespace GameOfChanceSimulator
{
    public class HistoricalDataSet
    {
        readonly int Size; // read-only property to expose the number of the underlying data
        readonly IReadOnlyList<HistoricalDataPoint> DataPoints; 

        public HistoricalDataSet(ILogger)
        {
            // constructor
        }

         void Generate()
        {
            /* calling the method generates a single new (randomized) HistoricalDataPoint instance,
             * it adds this to the list of available DataPoints
             * stored by the class and finally appends a new entry to history.csv. */
        }

        void Load()
        {
            /* calling the method reads already generated data points from history.csv,
             * it creates an instance of HistoricalDataPoint for each entry in the CSV file. */
        }

    }
}

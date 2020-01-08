using System;

namespace GameOfChanceSimulator

{
    class Program
    {
        static void Main(string[] args)
        {
            GameSimulator alma = new GameSimulator();
            int num = Convert.ToInt32(args[0]);
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(alma.Simulator());
            }


            HistoricalDataSet GenerateHistoricalDataSet(string[] something)
            {

                /* alling the method generates historical data (as many rounds as the rounds parameter specifies) or
                if the parameter's value is 0 it loads existing data from a file called history.csv. */

                return null;
            }
        }
    }
}

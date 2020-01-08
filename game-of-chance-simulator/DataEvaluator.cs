using System;
namespace GameOfChanceSimulator
{
    public class DataEvaluator
    {
        public DataEvaluator()
        {
        }

        public DataEvaluator(HistoricalDataSet, ILogger)
        {

        }

        Result Run()
        {
            /* calling the method uses the data evaluator's state
             * (the data points it was supplied during its construction)
             * to do some calculation in order to be able to create a Result instance.
             * E.g. in a horse race simulator it counts and determines which horse won first place most frequently
             * and what's the percentage of winning when betting on that horse.
             * Important: keep it dead simple, creating a game with convulated logic is not the point. */

            return null;
        }
    }
}

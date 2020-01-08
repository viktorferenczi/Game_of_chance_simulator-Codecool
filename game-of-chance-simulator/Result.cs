using System;
namespace GameOfChanceSimulator
{
    public class Result
    {
        public int NumberOfSimulations { get; private set; }
        public string BestChoice { get; private set; }
        public float BestChoiceChance { get; private set; }

        public Result(int NumberOfSimulations, string BestChoice, float BestChoiceChance)
        {
            this.NumberOfSimulations = NumberOfSimulations;
            this.BestChoice = BestChoice;
            this.BestChoiceChance = BestChoiceChance;
        }
    }
}

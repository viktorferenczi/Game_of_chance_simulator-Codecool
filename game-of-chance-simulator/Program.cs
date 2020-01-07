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
            
        }
    }
}

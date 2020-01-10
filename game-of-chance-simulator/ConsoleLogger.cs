using System;
namespace GameOfChanceSimulator
{
    public class ConsoleLogger : ILogger
    {
        DateTime now = DateTime.Now;
        public ConsoleLogger()
        {
            
        }

        public void Error(string message)
        {
            // error logging
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Error ");
            Console.ResetColor();
            Console.Write(now.ToString("F") + " : " + message+"\n");
        }

        public void Info(string message)
        {
           // info logging
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("INFO ");
            Console.ResetColor();
            Console.Write(now.ToString("F")+ " : "+ message+"\n");

            
        }


    }
}

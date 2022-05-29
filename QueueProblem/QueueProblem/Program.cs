using System;

namespace QueueProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome In Queue Program");
            int input;
            do
            {
                Console.WriteLine("\n1: Add Element in Queue");
                input = int.Parse(Console.ReadLine()); 
                switch(input)
                {
                    case 1:
                        QueueProgram.Insert();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            while (input != 0);
        }
    }
}

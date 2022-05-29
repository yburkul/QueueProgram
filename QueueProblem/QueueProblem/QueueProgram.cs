using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueProblem
{
    public class QueueProgram
    {
        public static void Insert()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Welcome in Queue Operations");
            int input;
            do
            {
                Console.WriteLine();
                Console.WriteLine("1: Displaying the beginning element of Queue by using Peek Method");
                Console.WriteLine("2: Count the Element in queue");
                Console.WriteLine("3: Retrieveing top element of Queue by using Dequeue Method");
                Console.WriteLine("4: Checking whether the element is Present or Not");
                Console.WriteLine("5: Count the Element");
                
                input=int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine(queue.Peek());
                        break;
                    case 2:
                        Console.WriteLine("Count the Element in queue: " + queue.Count);
                        break;
                    case 3:
                        Console.WriteLine("\nBefore Removing Element Count is: " + queue.Count);
                        Console.WriteLine("\nRemoving the Element From Queue is: " + queue.Dequeue());
                        Console.WriteLine("\nAfter remove queue the top element is: " + queue.Peek());
                        Console.WriteLine("\nAfter Removing Element Count is: " + queue.Count);
                        break;
                    case 4:
                        Console.WriteLine(queue.Contains(20));
                        break;
                    case 5:
                        Console.WriteLine("\nBefore Removing All Element from queue the Count is: " + queue.Count);
                        queue.Clear();  
                        Console.WriteLine("\nAfter Removing All Element from queue the Count is: " + queue.Count);
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;

                }
            }
            while(input!=0);
        }
    }
}

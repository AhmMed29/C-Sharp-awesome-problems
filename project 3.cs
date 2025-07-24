// hey ! i made this project to implement what i learned in data structure 
// this is a very simple project using ==> Priority Queue

using System.Collections.Generic;
namespace TaskManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = new Task(); // must be created 
            Console.WriteLine("Welcome To Your Task Manager");
            Console.WriteLine("############################");
            // Add Task and set priority
            // view task by priority
            // Exit
            while (true)
            {
                Console.WriteLine("Choose from below :");
                Console.WriteLine("1.Add a Task\n2.View Tasks\n3.Exit");
                int userinput = int.Parse(Console.ReadLine());
                switch (userinput)
                {
                    case 1:
                        task.userinput();
                        break;
                    case 2:
                        task.viewtask();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter a number from 1 to 3");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
    public class Task
    {
        PriorityQueue<string, int> mytasks = new PriorityQueue<string, int>();
        public void userinput()
        {
            Console.WriteLine("Enter your task name");
            string inputtaskname = Console.ReadLine(); // Name
            Console.WriteLine("Enter task priority from 1 to 5 (the most Priority number 1)");
            int inputtaskpriority = int.Parse(Console.ReadLine()); // Priority
            
            mytasks.Enqueue(inputtaskname, inputtaskpriority);
        }
        public void viewtask()
        {
            while(mytasks.Count != 0)
            {
                string item = mytasks.Dequeue();
                Console.WriteLine(item);
            }
        }
    }
}
// This code is a simple task management console application in C# using a periority queue.
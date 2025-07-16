namespace TaskTracker
{
    class Program
    {
        // suppose the size is 100 !
        static string[] tasksave = new string[100];
        static int taskindex = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To My App");
            Console.WriteLine("pick me a number to :\n1.Add Task\n2.View Task");
            Console.WriteLine("3.Mark Task\n4.Remove Task\n5.Exit");
            while (true)
            { 
                Console.WriteLine("Enter your choice from 1 to 5");
                string userchoice = Console.ReadLine();
                switch (userchoice)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ViewTasks();
                        break;
                    case "3":
                        MarkTask();
                        break;
                    case "4":
                        RemoveTask();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter number from 1 : 5");
                        break;
                }
            }
        }

        private static void AddTask()
        {
            Console.WriteLine("Enter task title");
            string tasktitle = Console.ReadLine();
            tasksave[taskindex] = tasktitle;
            taskindex++;
        }
        private static void ViewTasks()
        {
            for (int i = 0; i < taskindex; i++)
            {
                Console.WriteLine($"{i + 1}. {tasksave[i]}");
            }
        }
        private static void MarkTask()
        {
            Console.WriteLine($"enter the task index to Mark it --> from 0 to {taskindex - 1}");
            int tasknum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{tasksave[tasknum]} is completed");
            tasksave[tasknum] = tasksave[tasknum] + " (COMPLETED)";
        }
        public static void RemoveTask()
        {
            Console.WriteLine($"enter the task index to remove it --> from 0 to {taskindex - 1}");
            int tasknum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{tasksave[tasknum]} is deleted");
            tasksave[tasknum] = "";
        }
        
    }
}

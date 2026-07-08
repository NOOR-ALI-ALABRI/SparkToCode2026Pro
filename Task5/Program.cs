namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        /*
        //Task 1 - Fixed Grades Array
        int[] grades = new int[5];
        for (int i = 0; i < grades.Length; i++)
        {
            Console.Write("Enter grade: ");
            grades[i] = int.Parse(Console.ReadLine());
        }
        foreach (int grade in grades)
        {
            Console.WriteLine(grade);
        }
        
        
        
        //Task 2 - Dynamic To-Do List
         
        List<string> tasks = new List<string>();
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter task: ");
            string task = Console.ReadLine();

            tasks.Add(task);
            
        }  
        Console.WriteLine("To-Do List:");// Print tasks

        foreach (string task in tasks)
        {
            Console.WriteLine("- " + task);
        }
        
        */
        //Task 3 - Browsing History Stack
        Stack<string> history = new Stack<string>();
        history.Push("google.com");
        history.Push("microsoft.com");
        history.Push("github.com");
        Console.WriteLine("Current stack:");
        foreach (string site in history)
        {
            Console.WriteLine(site);
        }
        history.Pop();

        Console.WriteLine("You are now on: " + history.Peek());
        
        
        
    }
}
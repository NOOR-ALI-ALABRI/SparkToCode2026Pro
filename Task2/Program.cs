namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        //Task 1 - Countdown Timer
        Console.WriteLine("enter a starting number:"); 
        int number = int.Parse(Console.ReadLine());
        for(int i=number ; i >= 1 ; i--) 
            Console.WriteLine(i);
        
        //Task 2 - Sum of Numbers 1 to
        
        Console.WriteLine("enter a positive whole number:"); 
        int num = int.Parse(Console.ReadLine());
        int sum = 0;
       for (int i = 1; i <= num; i++) 
           sum = sum + i;
           Console.WriteLine("Sum = " + sum);

        

    }
}
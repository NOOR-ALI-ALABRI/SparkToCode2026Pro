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

           //Task 3 - Multiplication Table

           Console.WriteLine("Enter a number:");
           int num = int.Parse(Console.ReadLine());
           for (int i = 1; i <= 10; i++)
           
           /////////////////////////
           ///Task 4 - Password Retry
           string Password = "Spark2026";
           Console.WriteLine("Enter password:");
           string input = Console.ReadLine();
           
           
           while (input != Password)
           {
               Console.WriteLine("Incorrect password, try again");
               Console.WriteLine("Enter password:");
               input = Console.ReadLine();
           }

           Console.WriteLine("Access Granted");
           ///////////////////////////////
           //Task 5 - Number Guessing Game
           
           int secret = 42;
           int guess;
           int attempts;
           do
           {
               Console.WriteLine("Guess the number:");
               guess = int.Parse(Console.ReadLine());
               attempts++;

               if (guess > secret)
                   Console.WriteLine("Too high");
               else if (guess < secret)
                   Console.WriteLine("Too low");
               else
                   Console.WriteLine("Correct!");
           }while (guess != secret);
           Console.WriteLine("Attempts: " + attempts);
    }
}